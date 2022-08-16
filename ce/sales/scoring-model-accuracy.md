---
title: "View the accuracy and performance of predictive scoring models"
description: "Accuracy of the predictive model is determined by running the model on historical data and calculating false positives, false negatives, true positives, and not true negatives."
ms.date: 08/16/2022
ms.custom: 
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# View the accuracy and performance of a predictive scoring model

By validating the AI predictions with actual values, you'll gain more confidence about the accuracy of the AI-driven insights. This helps you to convey and convince the leadership team and sellers to adopt the model and motivate them to use the AI model’s insights more often for improved business outcomes.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## View accuracy and performance metrics 

1. Go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.

2. On the site map under **Predictive models**, select **Opportunity scoring** or **Lead scoring**.

1. From the **Select model** drop-down, select the model for which you want to view the accuracy report.
    The Analytics tab displays the accuracy and performance metrics of the model.
    :::image type="content" source="media/predictive-scoring-accuracy.PNG" alt-text="A screenshot of the Analytics tab displaying model accuracy metrics":::

    Let's understand the metrics with an example:

    Historical data size: 1000 opportunities 
    Predicted to win: 800
    Actual won: 650 
    Predicted to lose: 200 
    Actual lost: 350 
    
    Out of the 800 opportunities that were predicted to be won, 650 were actually won. So 650 are the true positives (TP) and the remaining 150 are  false positives (FP). Similarly, 200 opportunities were predicted to lose but 350 opportunities were actually lost. In this case, 200 are true negatives (TN) and the remaining 150 are false negative (FN). To summarize, 

    True positives: 650
    True negatives: 200
    False positives: 150
    False negatives: 150
 
    - **Model Performance**
        Specifies whether the model is ready to publish based on the following parameters:
        
        - **Accuracy**  
            Displays the percentage of leads or opportunities that were correctly predicted to be qualified or won. A score above 50% is considered healthy and accurate enough. 
            Accuracy = True positives + True negatives / Total number of opportunities scored * 100
            The accuracy score for our example data can be calculated as follows:
            Accuracy=(650+200)/1000*100 = 85%

        - **Precision**  
            Displays the percentage of leads or opportunities that were qualified or won as per the model's predictions. A score above 25% is considered healthy.
            Precision = True positives / (True positives + False positives) * 100
            The precision score for our example data can be calculated as follows:
            Precision=650/650+150*100 = 81%
        

        - **Conversion rate**  
            Displays the percentage of leads or opportunities that are qualified or won as per historical data. A score above xx% is considered healthy.

    - **Confusion matrix**  
        Displays the true positives, true negatives, false positives, and false negatives by testing the model against historical data (how many days data is this? is there any desired limit).

        
        |Metric  |Predicted  |Actual  |Accuracy  |
        |---------|---------|---------|---------|
        |True positive (TP)     |    Yes     | Yes        | Good        |
        |True negative (TN)    |    No    |   No      | Good        |
        |False positive (FP)     |   Yes      | No        |Bad         |
        |False negative (FN)    |   No      |  Yes       |Bad         |
        
        A higher number of true positives and true negatives is good for the model whereas a higher number of false positive and false negative is detrimental.  

    - **Area under the curve**
        Displays the area under the cure (AUC) score of the model. The AUC score determines the probability that a model will rank a randomly chosen positive instance (won opportunity) higher than a randomly chosen negative one (lost opportunity). A model with higher AUC is better at predicting true positives and true negatives.  

    - **F1 score**
        Displays the F1 score calculated based on the model's precision and recall scores.
        Recall=TP/TP+FN*100
        The recall score for our example data can be calculated as follows:
        Recall=650/650+150*100 = 81%



