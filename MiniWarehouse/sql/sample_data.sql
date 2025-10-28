INSERT INTO Article (Sku, Name, MinQuantity) VALUES
('A-100', 'Banana Box', 10),
('A-200', 'Apple Crate', 20),
('A-300', 'Orange Pack', 15);

INSERT INTO Stocks (ArticleId, Quantity)
SELECT Id, 0 FROM Article;

INSERT INTO Booking (ArticleId, Delta, Reason)
SELECT id, 50, 'Initial Stock' FROM Article WHERE Sku = 'A-100';
UPDATE Stocks s JOIN Article a ON s.ArticleId=a.Id SELECT s.Quantity = s.Quantity + 50 WHERE a. Quantity = Quantity + 50 WHERE a.Sku='A-100';

INSERT INTO Booking (ArticleId, Delta, Reason)
SELECT id, 25, 'Initial Stock' FROM Article WHERE Sku = 'A-200';
UPDATE Stocks s JOIN Article a ON s.ArticleId=a.Id SELECT s.Quantity = s.Quantity + 25 WHERE a. Quantity = Quantity + 25 WHERE a.Sku='A-200';

INSERT INTO Booking (ArticleId, Delta, Reason)
SELECT id, -5, 'Initial Stock' FROM Article WHERE Sku = 'A-300';
UPDATE Stocks s JOIN Article a ON s.ArticleId=a.Id SELECT s.Quantity = s.Quantity -5 WHERE a. Quantity = Quantity + 30 WHERE a.Sku='A-100';