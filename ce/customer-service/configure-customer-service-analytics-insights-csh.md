---
title: "Configure Customer Service analytics and insights for Dynamics 365 in Customer Service Hub| MicrosoftDocs"
description: "Learn about Customer Service Analytics"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 06/26/2020
ms.topic: article
ms.service: 
  - "dynamics-365-customerservice"
ms.custom:
  - ""
applies_to:
---

# Preview: Configure Customer Service analytics and insights in Customer Service Hub

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
>
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided "as-is," "with all faults," "as available," and without warranty.
> - This preview feature does not come with technical support and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk. All previews are subject to separate [Terms and Conditions](../legal/supp-dynamics365-preview.md).

## Overview

You can configure the Customer Service analytics and Customer Service Insights reports in Customer Service Hub and share them with service managers, who can then view and analyze the different activities performed in Customer Service Hub. The following reports are available out of the box:

- **Analytics reports:** Customers can view BI analytics and metrics for their customer service organization.
- **Insights reports:** Customers can view Customer Service Insights reports with a combination of BI analytics and AI insights for their organization. The reports use natural language understanding to automatically detect the language used in your support cases and group related support cases into topics. More information: [Customer Service Insights overview](https://docs.microsoft.com/dynamics365/ai/customer-service-insights/overview)

## Configure Customer Service analytics reports in Customer Service Hub

Make sure that you have administrator permissions for Dynamics 365.

### Enable Customer Service analytics reports

1. Sign in to Dynamics 365 as an administrator, and go to Customer Service Hub.
2. In the **Change area**, select **Service Management** > **Settings (Preview)**. The **Analytics and insights settings** page appears.
    > [!div class=ms-imgBorder]
    > ![Customer Service analytics installation](media/cs-analyticsinsights-configure.png "Customer Service analytics installation")

3. In **Analytics reporting**, switch the toggle to **Enabled**. A provisioning message appears, and then **Share reports** appears after the provisioning is complete.

### Share Customer Service analytics reports

You can share the reports from the **Service Management** > **Settings (Preview)** > **Analytics and insights settings** page or the **Service** > **Analytics and Insights** > **Reports (Preview)** > **Data Analytics Reports** page.

1. On the **Analytics and insights settings** page, select **Share reports**. The **Data Analytics Reports** page displays the list of available reports.
    > [!div class=mx-imgBorder]
    > ![Customer Service data analytics report](media/cs-data-analytics-reports.PNG "Customer Service data analytics report")

2. Select a report. The report opens on a new page.
3. Select **Share**. The **Share data analytics report** dialog box appears.
    > [!div class=mx-imgBorder]
    > ![Customer Service share data analytics report](media/cs-share-report.png "Customer Service share data analytics report")
4. Select **Add User/Team**. The **Look Up Records** dialog box appears.
5. Search for users, and then add them. The users appear in the table.
6. Select the permissions&mdash;such as Read, Write, and Share&mdash;that you want to grant on the report, and then select **Share**. The report is shared with the selected users.

### View Customer Service analytics reports

The service managers must have the admin or service manager role to view the reports. Users with the CSR Manager role will be able to view the reports only after the reports are shared with them.

You can see the following reports by navigating to the **Service** > **Analytics and Insights** > **Reports (Preview)** > **Data Analytics Reports** page.

- [Case Summary report](customer-service-analytics.md#1-summary)
- [Agent Summary report](customer-service-analytics.md#2-agent-and-queue)

## Configure Customer Service Insights reports

Make sure that the following prerequisites are met:

- Administrator permissions for Dynamics 365
- A valid Customer Service Insights license

  > [!NOTE]
  > The Customer Service Insights license is needed for customers who have licenses for Dynamics 365 Customer Service Enterprise.

### Install Customer Service Insights reports

1. Sign in to Dynamics 365 as an administrator, and go to Customer Service Hub.
2. In the **Change area**, select **Service Management** > **Settings (Preview)**. The **Analytics and insights settings** page appears.
3. Select **Get started**. The **Install Customer Service Insights** page displays the installation process for the following:
   - Checks whether the administrator has a valid Customer Service Insights license to run the installation.
   - Installs the Customer Service Insights solution if the license check is passed. The following are also created:
     - **Customer Service Insights AppUser:** An application user entity that's used to allow Customer Service Insights to perform actions on behalf of users.
     - **Customer Service Insights Configuration:** A Common Data Service entity in your organization environment that's used by admins to control the report's entry access in the site map.
   - Generates insights and sets up reports for the administrator.
  
  The installation process might take a few minutes. You can navigate away from the page and revisit it to check the status. 
  
  After the installation, **Go to settings** appears on the installation page.

   > [!div class=ms-imgBorder]
   > ![Customer Service Insights reports installation](media/install-csi-reports-csh.png "Customer Service Insights reports installation")

4. Select **Go to settings**. The **Analytics and insights settings** page is displayed.
    > [!div class=ms-imgBorder]
    > ![Customer Service Insights reports installed](media/csi-reports-installed-settings.png "Customer Service Insights reports installed")

### Change security roles

By default, users with the following security roles will be able to see **Insights (Preview)** in the site map:

- Administrator
- CSR Manager

To change the security role, edit the permission of the security role to the Customer Service Insights Configuration custom entity. More information: [Edit a security role](https://docs.microsoft.com/power-platform/admin/create-edit-security-role#edit-a-security-role)

### Configure Customer Service Insights settings

On the **Analytics and insights settings** page, you can do the following after the reports are created:

- **View reports:** Go to the Customer Service Insights reports in Customer Service Hub.
- **Share reports:** Open the Customer Service Insights standalone application, and share the reports with your coworkers. More information: [Sharing a workspace in Customer Service Insights](https://docs.microsoft.com/dynamics365/ai/customer-service-insights/use-workspaces#sharing-a-workspace).
- **Change settings:** Open the Settings dialog box in the Customer Service Insights standalone application, including data mapping and settings for topic generation. More information:
  - [Map your data to custom entities and fields](https://docs.microsoft.com/dynamics365/ai/customer-service-insights/map-data#to-map-data-by-specifying-data-mapping-settings)
  - [Improve data quality by cleansing support case titles](https://docs.microsoft.com/dynamics365/ai/customer-service-insights/settings)
  - [Set the granularity of how Customer Service Insights generates customer service topics](https://docs.microsoft.com/dynamics365/ai/customer-service-insights/granularity)

> [!IMPORTANT]
> After you share the reports, only those users who have a valid Customer Service Insights license can view them.

### View Customer Service Insights reports

Go to **Service** > **Analytics and Insights** > **Insights (Preview)**. The **Home** page is displayed.

  > [!div class=ms-imgBorder]
  > ![Customer Service Insights home](media/csi-reports-home.png "Customer Service Insights home")

You can view the following reports:

- **Home page:** Presents key insights from your customer service data in a visually rich way, making it easier to discover topics and issues to focus on and see why they were suggested.
- **KPI summary:** Gives a broad overview of the customer service experience at your organization. It uses AI technology to show you topics that are generating the highest volume and emerging topics with the highest rate of change in volume.
- **New cases:** Gives an overview of the new cases in your customer service system. It uses AI technology to help you identify popular and emerging issues.
- **Customer satisfaction:** Gives an overview of customer satisfaction and uses AI technology to show you topics that are having the greatest impact on customer satisfaction scores.
- **Resolutions:** Gives you an overview of your customer service system's case resolution performance. It uses AI technology to show you topics that are having the greatest positive or negative impact on resolution time.

### See also

[Introduction to Customer Service analytics and insights](introduction-customer-service-analytics.md)  
[View and understand Customer Service analytics and insights in Customer Service Hub](customer-service-analytics-insights-csh.md)  
[View and understand Customer Service analytics](customer-service-analytics.md)  