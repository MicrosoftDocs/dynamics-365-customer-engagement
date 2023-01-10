---
title: Reports in Dynamics 365 Field Service | MicrosoftDocs"
description: Learn about how to use work order summary reports in Dynamics 365 Field Service.
ms.date: 10/01/2020
ms.reviewer: mhart

ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: jshotts
ms.author: jasonshotts
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Use the reports


## View and filter reports

You can filter reports by the following criteria: 

- **Customer** 
- **System status**
- **Work order type**
- **Substatus**
- **Service territory**
- **Technician**
- **Date range**

See the following screenshot of the work order summary report for reference. 

![Screenshot showing the work order summary report filter options.](./media/report-filter-example.png)

## Refresh reports
The information in reports is refreshed every 24 hours. You may see a yellow, triangular warning icon next to the label **Last refresh (UTC)** in the top-right of the report. This icon indicates whether there is a delay or issue with the data refresh. If the data has not been refreshed in the last 24 hours, you'll see a tooltip message when you hover over the icon.

|    Refresh   status                       |    Indicator   Icon    |    Tooltip   message                                                                                                                       |
|-------------------------------------------|------------------------|--------------------------------------------------------------------------------------------------------------------------------------------|
|    Within or close to SLA (24 hours)    |    Not visible         |    The data set is up to date.                                                                                                             |
|    Missed SLA (>24 hours)               |    Visible             |    Due to the delay with the refresh process, the data set has not been refreshed and you can reach out to your system administrator.    |

## Share reports

By default, the tenant administrator will be able to view all the reports, but by following the below steps, they can also share reports with other users or teams.

1. To share a report, select **Share** in the top-right corner of the report. 
 
2. Select the **Work order summary** report.

3. Select **Share**.

4. Select **Add User/Team** and then choose the user you want to share the report with.

    ![Screenshot showing the add user or team option on the share reports screen.](./media/report-share.png)

5. Make sure the **Read** access is selected and then select **Share**.

    ![Screenshot showing the share window with emphasis on the read box being checked.](./media/report-share-read-checked.png)

The user or team you selected will now be able to see the report. 