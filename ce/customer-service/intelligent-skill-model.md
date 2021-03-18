---
title: "Set up model | MicrosoftDocs"
description: "Learn about how to enable skill-based routing and create rating model in Omnichannel for Customer Service app."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 12/13/2019
ms.topic: article
ms.service: dynamics-365-customerservice
---
# Set up intelligent skill finder model

You can create and train machine learning models that use AI to determine the necessary skills for new work items.

## Create skill finder models

Perform the steps in this section to set up intelligent skill finder models.

1. In the Omnichannel admin center, select **User attributes** in the site map.
2. On the page that appears, select **Manage** beside **Intelligent skill finder**.
3. Select **New**, and on the **Configuration** tab of **New skill finder model** page, enter a name.
4. In **Data criteria**, enter the following to form the dataset records:
    - **Attributes (Required):** Select attributes from conversation parameters or related entity parameters to form the training dataset. The corresponding attribute values will be merged in the sequence they are added and will be used to form the input string for the model training data.
    - **Filters:** Apply filters to conditionally select the relevant records.
    - **Date range:** Select a value to set the time period for which records needs to be fetched.
 5. Select load training data to fetch the records and to auto navigate to ‘Training data’ section



