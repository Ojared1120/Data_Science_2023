# CryptoClustering Project

## Overview

This project applies Python and unsupervised learning techniques to predict the impact of 24-hour and 7-day price changes on cryptocurrencies. The analysis involves clustering cryptocurrencies based on their price changes and optimizing these clusters using Principal Component Analysis (PCA).

### Data Preparation

- **Data Normalization**: Use `StandardScaler()` from scikit-learn to normalize the data.
- **Scaled DataFrame**: Create a DataFrame with the scaled data, using the "coin_id" index from the original DataFrame.

### Clustering Cryptocurrencies

#### Original Scaled Data

- **Elbow Method**: Apply the elbow method to find the best value for k.
- **K-means Clustering**: Cluster the cryptocurrencies using K-means with the optimal k value.
- **Visualization**: Create scatter plots using hvPlot to visualize the clusters.

#### PCA Optimized Data

- **PCA Application**: Perform PCA to reduce features to three principal components.
- **Elbow Method with PCA Data**: Apply the elbow method again using the PCA data to find the best k value.
- **K-means Clustering with PCA Data**: Cluster the cryptocurrencies using the PCA data.
- **Visualization**: Create scatter plots to visualize the PCA-based clusters.

### Analysis Questions

- Determine the best value for k using both original and PCA data.
- Analyze the impact of using fewer features on clustering with K-means.
