/* This Is Script to create a new Database */
Create Database IU_VP_Script_DB

Use IU_VP_Script_DB
Create Table Students
(
	StudentID int PRIMARY Key Identity(1,1),
	StudentName nvarchar(50) not null
)
/* Insert A new Record into the student */
Insert into Students(StudentName) Values ('Rama')
Insert into Students(StudentName) Values ('Adi')

/* Return all the Records From The Student Table */
Select* From Students

/* Update  A record by using the PRIMARY KEY*/
Update Students set StudentName='Rama Rajeh' Where (StudentID=3)

/*Delete A Record by Using The Primary Key Value */
Delete From Students Where StudentID=4
