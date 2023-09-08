# Crowdfunding ETL Project

## Overview

This project entailed creating an ETL pipeline to facilitate the structured analysis of a crowdfunding dataset. We utilized Python, Pandas, and PostgreSQL to transform raw data from Excel files into a structured format in a Postgres database.

## Repository Structure

- **ETL_Mini_Project_Owen_Jared.ipynb**: The main Jupyter Notebook housing the Python and Pandas codes essential in establishing the ETL pipeline.
- **Resources**: A directory harboring the initial datasets in `.xlsx` format.
- **CSV Files**: 
  - **category.csv**
  - **subcategory.csv**
  - **campaign.csv**
  - **contacts.csv**
- **crowdfunding_db_schema.sql**: This PostgreSQL schema file delineates the structure of the database and tables.
- **ERD Diagram**: This graphical representation outlines the relationship dynamics between different tables in the database.

## Process Flow

1. **Data Extraction and Transformation**:
   - **Data Extraction**: Involved siphoning data from `crowdfunding.xlsx` and `contacts.xlsx`.
   - **DataFrames Creation and Transformation**:
     - **Category and Subcategory**: Here we identified unique categories and subcategories, assigning distinct IDs to each entity.
     - **Campaign DataFrame**: Involved meticulous processing of different columns to ensure appropriate date formats and data type conversions.
     - **Contacts DataFrame**: Entailed dividing the name column into first and last names, coupled with extracting pertinent columns with optimal data type transformations.

2. **Database Creation and Data Loading**:
   - **ERD Development**: We utilized QuickDBD to construct a visualization of the database structure.
   - **Database Schema Definition**: Here we defined the table schemas in PostgreSQL, where we established appropriate data types, primary keys, and foreign keys to maintain dataset relationships.
   - **Data Loading**: This phase involved importing the transformed data from CSV files into the PostgreSQL database, corroborating the data accuracy through selective SQL queries.

## Tools Employed

- **Python**: The backbone for data extraction and transformation processes.
- **Pandas**: Leveraged for efficient data manipulation and analysis.
- **PostgreSQL**: The database system used for crafting and managing the database.
- **QuickDBD**: An indispensable tool in creating the ERD diagram that visually mapped the database's structure.
