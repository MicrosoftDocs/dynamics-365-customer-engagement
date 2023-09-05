---
title: Set up intelligent skill finder model in unified routing
description: Use the information to set up intelligent skill finder model for unified routing in Customer Service.
ms.date: 09/06/2023
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.collection:
ms.custom: bap-template
---

# Set up intelligent skill finder model

To configure machine learning-based skill classification rulesets, you can configure intelligent skill finder models that can be used for predicting skills.

You can create and train machine-learning models that use AI to determine the necessary skills for new work items. You can create and train the model by using the data in Microsoft Dataverse. However, if you're trying to set up the model in a new organization or if skill-based routing wasn't in use, you might not have the needed skill data. In such conditions, you can use data from another application by using the **Import from Excel** option in the skill finder model.

Intelligent skill finder depends upon the custom AI Builder category classification model. Therefore, AI Builder should be available in the geographical region where you want to use intelligent skill finder. More information: [Availability of AI Builder](/ai-builder/availability-region).

 > [!IMPORTANT]
 > If you want to import skill finder models from one environment to another, make sure that you import and export between environments of the same type. A model trained in test environment will work only in another test environment and not in a production environment.

## Create skill finder models

You can set up the intelligent skill finder model rating models in the Customer Service admin center app. You can create as many models as your business requires.

1. In Dynamics 365, go to one of the apps, and perform the following steps.

   ### [Customer Service admin center](#tab/customerserviceadmincenter)

     - In the site map, select **Insights** in **Operations**. The **Insights** page appears.
     
   ### [Omnichannel admin center](#tab/omnichanneladmincenter)

     - In the site map, select **User attributes** in **Advanced settings**. The **User attributes** page appears.

1. In the **Intelligent skill finder** section, select **Manage**.

1. On the **Intelligent skill finder models** page, select **New**, and on the **Configuration** tab of **New skill finder model** page, enter a name.

1. In **Data criteria**, enter the following to form the dataset records:
    - **Attributes (Required)**: Select attributes in the Attributes and related list to form the training dataset. The corresponding attribute values will be merged in the sequence they are added and will be used to form the input string for the model training data.
    - **Filters**: Optionally, apply filters to conditionally select the relevant records.
    - **Date range**: Select a value to set the time period for which the records need to be loaded.
    
    ![Configure skill finder model.](media/ur-skill-model.png "Configure skill finder model")

1. Select **Save**, and then select **Load training data**. The **Training data** tab appears and displays the data load status.

1. After the load is complete, review the data, and edit the records if you want to modify the tags.

1. In the **Training data** section, select the checkbox for **Input data** to select all the records, and select **Approve**. You must approve a minimum of 50 records for the model to be trained.

1. Select **Train model**, and select **Train model** again on the confirmation dialog.

1. After the status changes to training completed, select the rows that you want to publish, and select **Publish model**. The skills model is ready for use.

### Test the model

You should test the model to verify whether the model is working as per expectation. Perform the following steps in Power Apps to test the model.

1. In [Power Apps](https://make.powerapps.com/), select the environment that contains your solution.
1. Select **AI models** from
  - **My models** which has the models you created.
  - **Shared with me** which has the models shared to you.
1. Select the desired model from the list, and then select **Quick test**.

[!NOTE:]
> To get model related information, select ellipsis (...) beside **Quick Test** button, and then select **Download detailed metrics**. The downloaded metrics file contains the following information:
> - F1 scores (weighted, macro)
> - Accuracy
> - Tag related
>   - Accuracy, Accuracy baseline, Cohen kappa, F1 score, F1 score baseline, False negative predicted label distribution, False positive true label distribution, Grade, Number of cases test set, Number of cases total, Number of false negatives, Number of false positives, Precision, Recall.

1. In **Text** field, enter the desired input and select **Test**. You'll see the predicted tags in **Suggested tags and confidence**.

During runtime, if the predicted tags are matched with available skills in the organization, the corresponding skills are attached to the model.

![Test skill finder model.](media/test-skill-model.png "Test skill finder model")

### Retrain the model iteratively

You should retrain your published model iteratively to improve the model with new data in Microsoft Dataverse. For example, model retraining can be done by using the records in which agents have updated the skills for records or conversations. When you retrain the model to include the skills added by agents, review the training data records after loading it to make sure it meets the required skill criteria.

For information about how your agents can update skills, see [Manage skills](manage-skills.md). To enable your agents to update skills at runtime, see [Enable agents to update skills](allow-agents-update-skills.md).

You can define the conditions as seen in the following screenshot.

  ![Conditions to fetch data for retraining the model.](media/retrain-conditions.png "Conditions to fetch data for retraining the model")

### Use training data imported from Excel file

If you don't have data to train your model, you can populate skills and attributes data in Excel files and upload them to the application by using the import feature of Microsoft Dataverse.

To use the data from the Excel files, you must make sure of the following:

- The model name in the application should match the name in the Training record column of the Excel file.

- Name the files as msdyn_ocsitrainingdata.csv and msdyn_ocsitdskill.csv.

- Ensure that the input data string is less than or equal to 5000 characters to avoid truncation.
  
A sample of each file is as follows. You can select the links to download the sample files.

[**msdyn_ocsitrainingdata.csv**](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/unified-routing-isf-sample-data/msdyn_ocsitrainingdata.csv)

|Skill finder model|Training record name|Input data|
|------------------|--------------------|----------|
|CCSFM01-Contoso Coffee skill finder model|CCSFM01-Contoso Coffee training data A10001|Hi, I work at Trey Research. One of the automatic espresso machines is becoming overheated and starts giving a burning smell after 30 minutes of usage. Please help! Yes. No.|
|CCSFM01-Contoso Coffee skill finder model|CCSFM01-Contoso Coffee training data A10002|Hi, I recently bought Café A-100  coffee machine and its top plate is getting heated after 15 minutes of usage. Please resolve this at the earliest.|
|CCSFM01-Contoso Coffee skill finder model|CCSFM01-Contoso Coffee training data A10003|Hi, I am unable to start my recently bought espresso machine, looks like the electrical plug provided with it is not functioning.|
|CCSFM01-Contoso Coffee skill finder model|CCSFM01-Contoso Coffee training data A10004|Hi, I work at Trey Research. I am looking for replacement of coffee machine purchased 3 months ago. Even after raising complaints earlier about overheating the issue still persists. Please help! |
|CCSFM01-Contoso Coffee skill finder model|CCSFM01-Contoso Coffee training data A10005|Hi, my recently bought Café A-100 machine is not in the color I ordered. Please replace the same. |

[**msdyn_ocsitdskill.csv**](https://github.com/microsoft/Dynamics365-Apps-Samples/blob/master/customer-service/unified-routing-isf-sample-data/msdyn_ocsitdskill.csv)

|Training record|Characteristic mapping|Characteristic|
|---------|--------|-----------|
|CCSFM01-Contoso Coffee training data A10001|Café A-100|Café A-100|
|CCSFM01-Contoso Coffee training data A10001|Heating|Heating|
|CCSFM01-Contoso Coffee training data A10001|Electrical|Electrical|
|CCSFM01-Contoso Coffee training data A10002|Café A-100|Café A-100|
|CCSFM01-Contoso Coffee training data A10002|Heating|Heating|

Perform the following steps to upload the data for training your model:

1. On the **Skill finder model** page, enter a name for the model, and then save the form.
2. Select the **Training data** tab, and select **Import Excel**.
3. Select the .csv files to upload in the import tool.

   ![Import data file using Excel.](media/skill-finder-excel.png "Import data file using Excel")

4. Review the upload settings, and select **Finish** after you go through the stages. The data upload starts. The time taken for the data upload depends on the number of records.
5. Optionally, you can select **Refresh** to see the updated status of the data upload.
6. Perform steps 5 through 8 in [Create skill finder models](#create-skill-finder-models) to approve, train, and publish your model.