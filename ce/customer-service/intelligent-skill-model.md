---
title: "Set up skill training model | MicrosoftDocs"
description: "Learn about how to enable skill-based routing and create rating model in Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/09/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---
# Set up intelligent skill finder model

You can create and train machine learning models that use AI to determine the necessary skills for new work items.

## Create skill finder models

Perform the steps in this section to set up intelligent skill finder models.

1. In Omnichannel admin center, select **User attributes** in the site map, and then select **Manage** beside **Intelligent skill finder**.
2. Select **New**, and on the **Configuration** tab of **New skill finder model** page, enter a name.
3. In **Data criteria**, enter the following to form the dataset records:
    - **Attributes (Required)**: Select attributes in the Attributes and related list to form the training dataset. The corresponding attribute values will be merged in the sequence they are added and will be used to form the input string for the model training data.
    - **Filters**: Optionally, apply filters to conditionally select the relevant records.
    - **Date range**: Select a value to set the time period for which the records need to be loaded.
    
    ![Configure skill finder model](media/ur-skill-model.png "Configure skill finder model")

4. Select **Save**, and then select load training data. The **Training data** tab appears and displays the data load status.
5. After the load is complete, review the load, and edit the records if you want to modify the tags.
6. In the **Training data** section, select the checkbox beside **Input data** to select all the records, and select **Approve**.
7. Select **Train model**, and select **Train model** on the confirmation dialog box.
8. After the status changes to training completed, select the row you want to publish, and select **Publish model**. The skills model is ready for use.



