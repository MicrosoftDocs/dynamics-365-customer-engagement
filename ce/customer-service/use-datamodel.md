---
title: Use the out-of-the-box data model in your reports
description: How-to description #Required; article description that's displayed in search results. Don't enclose in quotation marks. Do end with a period.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: how-to #Required; don't change.
ms.collection: 
ms.date: 05/26/2023
ms.custom: bap-template #Required; don't change.
---


# Use the out-of-the-box data model in your reports

<!--Introductory paragraph. Required. Lead with a light intro that describes, in customer-friendly language, what the customer will learn, or do, or accomplish. Answer the fundamental "why would I want to do this?" question. Keep it short.-->
<!--add your intro paragraph here-->

<!--Prerequisites. Optional. If you need prerequisites, make them your first H2 in a how-to guide. Use clear language and use a list format.-->
## Prerequisites

<!--add your content here-->

<!--H2s. Required. A how-to article explains how to do a task. The bulk of each H2 should be a procedure.-->
## Creating a new report from scratch 

Creating a new report from scratch 

If you wish to create a new report that leverages the out of box data model, then

Open Power BI desktop  

Click on File -> New  

Click on Get data, and then select Microsoft Fabric and from the list select Power BI dataset (or) Search for Power BI datasets  

A screenshot of a computer

Description automatically generated with medium confidence

Select the appropriate data set, depending on your needs around historical metrics vs. real-time metrics. Make sure you pick the model in the managed workspaces.

The tables and attributes contained within the managed data model are now available for you to leverage within your report in the data panel  

Build visualizations as required and when complete click on File -> Publish, to publish the new report back to Power BI.  
 

Note: Use caution when using hidden out-of-box facts or dimension fields in your custom reports as these fields might get modified or deleted in future updates. 
  

## Add Dynamics data to exiting reports
 
If you wish to add Dynamics data to existing reports, like your operational dashboards 

Download a copy of the report you would like to add Dynamics data to. Make sure you download with live connection to data online.  

If you would like to edit the out-of-box copy of the report, download them from the customer workspace 

Open the downloaded file in Power BI.  

Click on Get data -> Power BI data sets  

Select the appropriate data set, depending on your needs around historical metrics vs. real-time metrics. Make sure you pick the model in the managed workspaces. 

The tables, attributes from the managed data model are now available for you to leverage within your report in the data panel  

Build visualizations as required and when complete click on File -> Publish, to publish the updated report back to Power BI.  

## Extend the out-of-box data model  
 

Adding new metrics based on data available within the Dynamics 365 Customer service dataset 

If you are looking to create a metric within the existing entities (as described in scenarios #1 and #2), you should  

Open the report you want to edit in Power BI desktop. Make sure you use the steps described in Leveraging the out of box data model in your reports, to ensure that your report is connected to the dynamics data model  

Right click on the entity in which you want to create your new metric 

Enter the DAX logic, after selecting the right attributes like name, data type etc. A screenshot of a computer

Description automatically generated 

Save your measure and include it in your visualization as you see fit  

Publish your newer version to Power BI by clicking on File -> Publish 
 

Let’s walk through this scenario with an example. Let us create a new Service level 150 seconds in real-time reports.  

Open your Power BI service, and navigate to the customer workspace 

Download the real-time report with live connection and open it in Power BI   

 you will right click on FactConversation and click on New measure.   

Refer to the <doc on reference> to get the logic used to calculate the out-of-box metrics, which you can use to build your logic.  



## Next steps

<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->
