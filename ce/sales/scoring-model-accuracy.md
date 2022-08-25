---
title: View the accuracy and performance of predictive scoring models
description: Accuracy of the predictive model is determined by running the model on historical data and calculating false positives, false negatives, true positives, and true negatives.
ms.date: 08/25/2022
ms.custom:
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# View the accuracy and performance of a predictive scoring model

By validating the AI predictions with actual values, you'll gain more confidence about the accuracy of the AI-driven insights. This helps you to convey and convince the leadership team and sellers to adopt the model and motivate them to use the AI model’s insights more often for improved business outcomes.

> [!NOTE]
> The accuracy and performance metrics are only available for models created after <date>. 

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## View accuracy and performance metrics 

1. Go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.

2. On the site map under **Predictive models**, select **Opportunity scoring** or **Lead scoring**.

1. From the **Select model** drop-down, select the model for which you want to view the accuracy report.

2. Select the **Analytics** tab.
    The accuracy and performance metrics of the model are displayed.
    :::image type="content" source="media/predictive-scoring-accuracy.PNG" alt-text="A screenshot of the Analytics tab displaying model accuracy metrics":::

    Let's understand the metrics with an example dataset:

    Historical data size: 1000 opportunities  
    Predicted to win: 800  
    Actual won: 650  
    Predicted to lose: 200  
    Actual lost: 350  
    
    Out of the 800 opportunities that were predicted to be won, 650 were actually won. So 650 are the true positives (TP) and the remaining 150 are  false positives (FP). Similarly, 200 opportunities were predicted to lose but 350 opportunities were actually lost. In this case, 200 are true negatives (TN) and the remaining 150 are false negative (FN). To summarize the numbers, 

    - True positives: 650
    - True negatives: 200
    - False positives: 150
    - False negatives: 150
 
    - **Model Performance**
        Specifies whether the model is ready to publish based on the following parameters:
        
        - **Accuracy**  
            Indicates how often your model makes correct predictions, either as positive or negative. This metric is most useful when the dataset is balanced, and the cost of false positives and false negatives is the same. The accuracy score is calculated using the following formula:
            
            Accuracy = (TP + TN) / (Total number of opportunities scored) *100
            
            The accuracy score for our example data is calculated as follows:
            Accuracy = (650+200) / 1000 *100 = 85%

        - **Recall**  
            Indicates how often the model predicted a positive outcome correctly compared to the actual positives. A low recall score means the model is predicting fewer true positives. The recall score is calculated using the following formula:

            Recall = TP / (TP + FN) * 100

            The recall score for our example data can be calculated as follows:
            Recall= 650 / (650+150) *100 = 81%
        

        - **Conversion rate**  
            Displays the percentage of leads or opportunities that are actually qualified/won as per historical data. This rate indicates the likelihood that an opportunity or lead will convert. This value is referenced by the model to determine how an attribute will influence the predictive score. 

    - **Confusion matrix**  
        Indicates how well your model is able to predict the outcomes when it was tested against historical data. The matrix displays the number of true positives, true negatives, false positives, and false negatives.

        
        |Metric  |Predicted  |Actual  |Accuracy  |
        |---------|---------|---------|---------|
        |True positive (TP)     |    Yes     | Yes        | Good        |
        |True negative (TN)    |    No    |   No      | Good        |
        |False positive (FP)     |   Yes      | No        |Bad         |
        |False negative (FN)    |   No      |  Yes       |Bad         |    
        
    - **Area under the curve**
        Displays the area under the curve (AUC) score of the model. The AUC score determines the probability that a model will rank a randomly chosen positive instance (a won opportunity) higher than a randomly chosen negative one (a lost opportunity). A model with higher AUC is better at predicting true positives and true negatives.  

    - **F1 score**
        Displays the F1 score calculated based on the model's precision and recall scores. The F1 score lets you determines the quality of the model even in instances of data imbalance. 

        Recall = TP / (TP+FN) *100

        The recall score for our example data can be calculated as follows:
        Recall = 650 / (650+150) *100 = 81%

    - **Threshold**
        Defines the threshold at which the lead or opportunity is considered as qualified/won. For example, if your threshold is 45, opportunities with a score greater than 45 will be predicted as won. The threshold is selected to optimize the F1 score. 

