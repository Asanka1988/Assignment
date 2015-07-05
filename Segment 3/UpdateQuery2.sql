USE PersonalDetails;
DECLARE  @ID INT = '4';
DECLARE  @Name VARCHAR(50) = 'Silve';
DECLARE  @Gender INT = '0';
DECLARE  @SectedDate DATE = '1989-04-05';

UPDATE Person
SET LastName='Samanmali'
WHERE FirstName = @Name AND Dob = @SectedDate;