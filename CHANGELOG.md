# Changelog

## 2026-10-26: Fixed the save button in frmNhapPhieuNhap

Only `frmNhapPhieuNhap` (`Form1.cs`, `Form1.Designer.cs`) and the SQL script were changed. No other forms were touched.

### What changed

**1. Small "Mới" button next to `cbMaPhuTung`**
- It creates the next part code in the format `PT` + number (`PT007`, `PT008`, ...).
- It takes the largest number already in the database **and** the codes on the grid that aren't saved yet, so adding two new parts to one receipt doesn't give them the same code.
- `cbMaPhuTung` is 60px narrower to make room for the button.

**2. Save button (`btnLuuPhieu`) rewritten**
- The whole receipt is now saved as **one T-SQL batch inside a transaction**, written in the same style as the database script (`BEGIN TRY / TRANSACTION / CATCH ROLLBACK / THROW`, `UPDATE ... FROM`, `OUTER APPLY`).
  **Why:** before, each statement ran on its own, so an error halfway left the receipt half-saved. Now either everything is saved or nothing is.
- The same logic handles a new receipt and an edited one. A new receipt simply has "old quantity = 0".
- Steps, in order:
  1. Block quantity changes on parts already used in a service (the part's service appears in `ChiTietPhieuTiepNhan`).
  2. Block changes that would make stock (`SoLuongTon`) negative.
  3. Check that the supplier exists.
  4. Insert `PhieuNhap`, or update it if it already exists.
  5. Create parts that don't exist yet. **Parts are only created through a receipt.**
  6. Update stock by the **difference** (new quantity − old quantity) for each part.
  7. If a part belongs **only** to this receipt, update its name, supplier, expiry date and prices from the grid.
  8. Rewrite `ChiTietPhieuNhap`.
  9. Delete parts that were removed from the receipt, have no stock left, and aren't used by any other receipt or by any `DichVu`.
  10. Recalculate `PhieuNhap.TongTien`, which was always 0 before.
- The form closes after a successful save. Before, it cleared the receipt code but kept the grid, so pressing Save again created a receipt with an empty code.

**3. Bugs fixed along the way**
| Bug | Cause |
|---|---|
| Opening a receipt for editing crashed | The query used `ct.MaNCC` / `ct.HanSuDung`, but those columns are now in `PhuTung` |
| In edit mode, "Thêm phụ tùng" gave an error | The grid was bound with `DataSource`, so `Rows.Add` wasn't allowed. Rows are now added one at a time |
| Adding a new part always failed | `DonViTinh` was `NOT NULL` but never filled (see 4) |
| Stock was sometimes not added | The update filtered on `HanSuDung = ...`, so a different expiry date matched nothing |
| The stock-subtract query on edit had a syntax error | Missing space before `From`, and `Join ... = ... =` instead of `Join ... On` |
| "Mã nhân viên không tồn tại!" when saving | The check read `txtMaNVNhap`, which is cleared after every added part. It now reads the employee code from the grid |
| Vietnamese part names were saved incorrectly | `N'...'` was missing |
| Dates and decimals depended on the machine's language settings | They're now written in a fixed format (`yyyy-MM-dd`, `.` as the decimal point) |
| A `'` in a name or note broke the SQL | It's now escaped with `EscapeSql` |

**4. Removed `DonViTinh` from `PhuTung`**: from the `CREATE TABLE` statement and the sample data in `QuanLySuaXe_SuaLoi_MaNCC.sql`. No C# code used it.

### Notes / not done
- `frmPhieuNhap.cs` (the print button) still joins `ct.MaNCC` / `ct.HanSuDung`, so **printing a receipt will fail**. I didn't touch it because it's outside the form I was told to change. The owner of that form should switch it to `pt.MaNCC` / `pt.HanSuDung`.
- **Re-run the SQL script** to recreate the database without `DonViTinh`. The script drops `QuanLySuaXe` first.
- For a part that's also on other receipts, saving only changes its stock. Its name and prices are left alone, so editing an old receipt doesn't overwrite newer prices.
- Tested on a temporary copy of the database: new receipt, lower a quantity, remove a part, change a quantity on a part used in a service (blocked), change only the note, and not enough stock (blocked). I haven't clicked through the UI itself.
