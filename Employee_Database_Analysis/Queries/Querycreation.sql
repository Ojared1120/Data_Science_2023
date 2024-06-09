CREATE TABLE Titles (
    title_id VARCHAR(10) PRIMARY KEY,
    title VARCHAR(255) NOT NULL
);

CREATE TABLE Departments (
    dept_no VARCHAR(10) PRIMARY KEY,
    dept_name VARCHAR(255) UNIQUE NOT NULL
);

-- Notice the FOREIGN KEY constraint placement
CREATE TABLE Employees (
    emp_no INT PRIMARY KEY,
    emp_title_id VARCHAR(10) REFERENCES Titles(title_id),
    birth_date DATE NOT NULL,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    sex CHAR(1) NOT NULL,
    hire_date DATE NOT NULL
);

CREATE TABLE Salaries (
    emp_no INT PRIMARY KEY REFERENCES Employees(emp_no),
    salary INT NOT NULL
);

CREATE TABLE Dept_Emp (
    emp_no INT REFERENCES Employees(emp_no),
    dept_no VARCHAR(10) REFERENCES Departments(dept_no),
    PRIMARY KEY (emp_no, dept_no)  -- This is a composite key
);

CREATE TABLE Dept_Manager (
    emp_no INT REFERENCES Employees(emp_no),
    dept_no VARCHAR(10) REFERENCES Departments(dept_no),
    PRIMARY KEY (emp_no, dept_no)  -- This is a composite key
);
