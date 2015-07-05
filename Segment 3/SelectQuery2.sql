USE PersonalDetails;
DECLARE  @SectedDate DATE = '1987-12-31';
SELECT * FROM Person WHERE DoB > @SectedDate;