CREATE VIEW Customer_View
             AS
             SELECT 客戶名稱 ,
					聯絡人數量 =(SELECT COUNT(客戶id)
					FROM 客戶聯絡人
					WHERE  客戶聯絡人.客戶id = 客戶資料.Id),

					銀行帳戶數量 =(SELECT COUNT(客戶id)
					FROM 客戶銀行資訊
					WHERE  客戶銀行資訊.客戶id = 客戶資料.Id)

             FROM 客戶資料

/* 有「客戶名稱、聯絡人數量、銀行帳戶數量」共三個欄位，用一個表格呈現報表即可。 */