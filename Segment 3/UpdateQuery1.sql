USE PersonalDetails;
DECLARE  @ID INT = '4';
DECLARE  @Gender INT = '0';
DECLARE  @SectedDate DATE = '1987-12-31';

UPDATE Person
SET LastName='Changed', Gender='1'
WHERE ID=@ID;