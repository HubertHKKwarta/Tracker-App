CREATE TABLE categories(
	id INT PRIMARY KEY IDENTITY(1,1),
	category VARCHAR(MAX) NULL,
	type VARCHAR(MAX) NULL,
	status VARCHAR(MAX) NULL,
	date_insert DATE NULL
)

SELECT * FROM categories