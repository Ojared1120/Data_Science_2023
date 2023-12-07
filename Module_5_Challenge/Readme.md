# Pymaceuticals Data Analysis

## Project Overview

Pymaceuticals, Inc., a burgeoning pharmaceutical company, has recently conducted a study on the effectiveness of anti-cancer medications, particularly focusing on squamous cell carcinoma (SCC). This README documents the analysis of the study's data, which involved 249 mice and a variety of drug regimens, including the company's drug of interest, Capomulin.

## Objective

The primary objective of this analysis is to compare the performance of Capomulin against other treatment regimens in controlling the development of SCC tumors in mice. This involves generating tables and figures for the technical report and providing a top-level summary of the study results.

## Data Preparation

- **Merging Data**: The analysis begins by merging `mouse_metadata` and `study_results` DataFrames.
- **Cleaning Data**: Identification and removal of any duplicate data entries, ensuring the integrity of the analysis.
- **Unique Mice Count**: Post-cleaning, the unique count of mice used in the study is documented.

## Analysis Tasks

1. **Generate Summary Statistics**: Creation of a DataFrame with statistics like mean, median, variance, standard deviation, and SEM of the tumor volume for each drug regimen.

2. **Visualization**: 
   - Bar Charts: Displaying the number of data points for each treatment regimen using both Pandas and Matplotlib.
   - Pie Charts: Showing the distribution of female versus male mice in the study.

3. **Quartile Analysis and Outlier Detection**: 
   - Calculation of quartiles, IQR, and identification of outliers for the most promising treatment regimens.
   - Generation of a box plot visualizing the distribution of final tumor volumes.

4. **Time Series Analysis**: 
   - Line plot of tumor volume vs. time point for a mouse treated with Capomulin.

5. **Scatter Plot and Correlation**: 
   - Scatter plot of mouse weight versus average tumor volume for the Capomulin regimen.
   - Calculation of the correlation coefficient and linear regression model.
