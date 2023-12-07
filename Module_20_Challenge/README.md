# Credit Risk Classification

## Overview

This project focuses on using machine learning to predict loan risk. Utilizing a dataset of historical lending activity from a peer-to-peer lending services company, we build a model to identify the creditworthiness of borrowers.

## Instructions

### Split the Data into Training and Testing Sets

- **Data Reading**: Read `lending_data.csv` into a Pandas DataFrame.
- **Label Creation**: Create the labels set (y) from the “loan_status” column.
- **Feature Creation**: Create the features (X) DataFrame from the remaining columns.
- **Data Splitting**: Split the data into training and testing datasets using `train_test_split`.

### Create a Logistic Regression Model with the Original Data

- **Model Fitting**: Fit a logistic regression model using the training data (X_train and y_train).
- **Predictions**: Save predictions for the testing data labels using X_test and the fitted model.
- **Model Evaluation**: 
  - Generate and analyze a confusion matrix.
  - Print and interpret the classification report.
- **Model Performance Analysis**: Assess how well the logistic regression model predicts both healthy and high-risk loan labels.

### Write a Credit Risk Analysis Report

- **Overview**: Provide an analysis overview explaining the purpose.
- **Results**: Describe the accuracy, precision, and recall scores of the machine learning model using a bulleted list.
- **Summary**: Summarize the results and provide a recommendation on the model's use by the company, with justification.

### Data Preparation

- **Data Reading**: Correctly reading the data into a DataFrame.
- **Label and Feature Creation**: Accurately creating labels and features.
- **Data Splitting**: Effectively splitting the data into training and testing sets.

### Logistic Regression Model

- **Model Fitting**: Properly fitting the model to the training data.
- **Prediction and Evaluation**: Accurately predicting and evaluating model performance.

### Credit Risk Analysis Report

- **Analysis Overview**: Clear explanation of the analysis purpose.
- **Model Results**: Detailed description of the model's accuracy, precision, and recall.
- **Summary and Recommendation**: Well-summarized results with a solid recommendation or justification.

