---
title: Use the out-of-the-box data model in your reports
description: How-to description #Required; article description that's displayed in search results. Don't enclose in quotation marks. Do end with a period.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: how-to #Required; don't change.
ms.collection: 
ms.date: 06/06/2023
ms.custom: bap-template #Required; don't change.
---


# Use the out-of-the-box data model in your reports

This articles describes how you can create a new report that leverages the out-of-the-box data model. You can also extend this report and add new metrics based on data available within the Dynamics 365 Customer Service dataset.

## Prerequisites

- Your administrator must have enabled data model customization. More information: [Enable Power BI data model customization](model-customize-reports.md#enable-power-bi-data-model-customization)
- You need to have the required [Power BI permissions](model-customize-reports.md#prerequisites).

## Create a new report based on Dynamics data

1. Go to Power BI desktop and then go to **File** >**New**.  

1. Select **Get data**, and then select **Microsoft Fabric (Preview)**, and from the list, select **Power BI dataset** or **Search for Power BI datasets**.

1. Select the appropriate data set, depending on whether you require historical or real-time metrics. Make sure you select the data model from managed workspaces.

    The tables and attributes from the managed data model are now available for you to use in your report in the data panel.

1. Select **Connect**.
1. After you are done with your edits, select **File** > **Publish**, to publish the new report back to Power BI.  

> [!NOTE]
> We recommend that you use hidden out-of-box facts or dimension fields in your custom reports cautiously, as these fields might get modified or deleted in future updates.

## Add Dynamics data to existing reports
 
To add Dynamics data to existing reports:

- Download a copy of the report. Make sure you download with live connection to data online.
- If you would like to edit the out-of-box copy of the report, then download the report from the customer workspace.

1. In Power BI, open the downloaded file.  

1. Select **Get data** **>** **Power BI data sets**.

1. Select the appropriate data set, depending on whether you require historical or real-time metrics. Make sure you select the data model from managed workspaces.

    The tables and attributes from the managed data model are now available for you to use in your report in the data panel.

1. After you are done with your edits, select **File > Publish**, to publish the updated report back to Power BI.  

## Extend the out-of-box data model

### Add new metrics based on data available in the Dynamics 365 Customer Service dataset

If you need to create a metric within the existing entities (as described in [Scenario 1 and Scenario 2](datamodel-overview.md#scenario-based-use-cases), perform the following steps:

1. Open the report you want to edit on Power BI desktop.
    Make sure you use the steps described in [Add Dynamics data to existing reports](#add-dynamics-data-to-existing-reports), to ensure that your report is connected to the dynamics data model.  

1. Right-click on the entity for which you want to create your new metric.

2. Enter the Data Analysis Expressions (DAX) logic for real-time metrics after selecting the required attributes such as name and data type. For more information on DAX, go to [Data Analysis Expressions (DAX) Reference](https://learn.microsoft.com/en-us/dax/).

3. Save your measure and include it in your visualization as required.

4. Publish your newer version to Power BI by selecting **File > Publish**.
 
> [!NOTE]
> If you need to rename an existing column, you'll have to create a new local model.  

Here's an example, which describes how to create a new service level of 150 seconds for real-time reports.  

1. Open your Power BI service, and navigate to the customer workspace.

1. Download the real-time report with live connection and open it in Power BI.

1. Right-click on **FactConversation** entity and select **New measure**.

    Refer to the **Data mappings for real-time reports** to get the logic used to calculate the out-of-box metrics, which you can use to build your logic.

1. Enter the following code:

    ``` 
    Service level (150 seconds) =  
        DIVIDE ( 
            SUMX ( 
                FactConversation, 
                IF ( 
                    FactConversation[ConversationFirstWaitTimeInSeconds] <= 150 
                        && FactConversation[IsAgentAccepted] 
                        && NOT FactConversation[DirectionCode], 
                    1, 
                    0 
                ) 
            ), 
          SUMX ( 
                FactConversation, 
                IF ( 
                    FactConversation[IsAgentAccepted] 
                        && NOT FactConversation[DirectionCode], 
                    1, 
                    0 
                ) 
            ), 
            BLANK () 
        ) 
    
    ```

1. Ensure that the format is **Percentage** and select **Save**.  

1. Replace the **Service level (60 seconds)** on the Summary Report page with the newly created Service level (150 seconds) measure.

1. Select **Save**, and then select **File > Publish** to Power BI.

### Add new metrics based on Dynamics 365 Customer Service dataset and external data

If you need to get additional data, both from within Dynamics Customer Service and outside of it, as described in [Scenario 3 and Scenario 4](datamodel-overview.md#scenario-based-use-cases), perform the following steps:  

1. Open the report you want to edit in Power BI desktop.

    Make sure you use the steps described in [Add Dynamics data to existing reports](#add-dynamics-data-to-existing-reports), to ensure that your report is connected to the dynamics data model.

1. Select the **Modeling** tab and then select **Make changes to this model**.

    You may be asked to create a local model to bring in additional data sources. This creates a data model within the workspace where the report exists. This local model (for the report) uses DirectQuery connection to connect to the Dynamics model, so, you can leverage metrics from the dynamics model while adding your own.  

1. Select **Add a local model**.
1. On the **Connect to your data** dialog, select **Submit**.
1. If you need to bring additional attributes from Dynamics, select **Dataverse**. For other applications, use the appropriate source.
1. On the **Navigator** pane, select the entity and then select **Transform data**.
1. On the **Connection Settings** dialog, select **DirectQuery** and then select **OK**.

1. After the local model is created, select **Get data** and the appropriate data source.  

1. On the **Modeling** tab, select **Manage relationship**, to create relationships between the new entities that you have added with existing entities.  

1. Right-click on the entity for which you want to create your new metric.

1. Enter the DAX logic, after selecting the required attributes such as name and data type.

1. Save your measure and include it in your visualization as required.  

1. Publish your newer version to Power BI by selecting **File > Publish**.

Here's an example, which describes how to filter the out-of-the-box Customer service historical reports by a user’s title.  

1. Open your Power BI service, and navigate to the customer workspace.

1. Download the Customer service historical analytics report with live connection and open it in Power BI.

1. Create the local model by following the steps explained earlier.

1. In the **Navigator** pane, select the appropriate Dynamics Customer Service organization. As the metrics will be based on Dynamics data, Dataverse connector is used.

1. From the list of entities, select the entity (or entities) that you need. Use the **system user** entity.  
 
1. Select **Transform data** to apply the necessary filters and to remove unwanted columns.

    As a best practice, make sure you pull only the data that is necessary to ensure optimal performance and refresh rates. You can choose to use **Import** mode or **DirectQuery** mode depending on the your needs. In case of real-time reports, you may choose to use **DirectQuery** as you'll get the latest data every time. To prevent any confusion, this entity can be named as **UserTitle**.
 
    The new entity **UserTitle** and the **Title** attribute are loaded and available for you. To successfully create a relationship between this new entity and existing data, we need the User Id as well.  

1. Select the **Modeling** tab, and **Manage relationship** to create a new relationship between **DimAgent** entity and  the newly created **UserTitle** entity using the agent Id attribute.  

    You can then add this as a filter to the existing report or add newer metrics if required based on this attribute.  

1. Select **Save** and then select **File** **>** **Publish to Power BI**.
 
## Publish reports back to Dynamics 365 Customer Service  

After you have created the new reports, you can enable your Dynamics users to view these reports from the Customer Service workspace. Work with your administrators to ensure the viewers have appropriate access to [view and then embed](configure-customer-service-analytics-insights-csh.md) these reports on Dynamics.  

## Next steps

[Customize data models of historical and real-time analytics reports](model-customize-reports.md#customize-data-models-of-historical-and-real-time-analytics-reports)
