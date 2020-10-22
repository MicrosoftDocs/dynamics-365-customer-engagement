---
title: "Configure Customer Service insights for Dynamics 365 in Customer Service Hub and Customer Service workspace | MicrosoftDocs"
description: "Learn how to configure Customer Service Insights in Customer Service Hub and Customer Service workspace"
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 10/22/2020
ms.topic: article
ms.service: 
  "dynamics-365-customerservice"
ms.custom:

---

# Preview: Configure Customer Service Insights for Customer Service Hub and Customer Service workspace

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
>
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided "as-is," "with all faults," "as available," and without warranty.
> - This preview feature does not come with technical support and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk. All previews are subject to separate [Terms and Conditions](../legal/supp-dynamics365-preview.md).

## Overview

You can configure the Customer Service Insights reports for Customer Service Hub and Customer Service workspace and share them with service managers, who can then view and analyze the different activities performed. Configuring the reports is done in Customer Service Hub, but applies to both Customer Service Hub and Customer Service workspace.

The following reports are available out of the box:

- **Insights reports:** Customers can view Customer Service Insights reports with a combination of BI analytics and AI insights for their organization. The reports use natural language understanding to automatically detect the language used in your support cases and group related support cases into topics.

The following historical reports are available:

- **Summary**  
- **Agent**
- **Topics** 
- **Knowledge search analytics (preview)** 

## Enable Customer Service analytics reports in Customer Service Hub 

Make sure that you have administrator permissions for Dynamics 365.

1. Sign in to Dynamics 365 as an administrator, and go to **Customer Service Hub**.

2. In the **Change area**, select **Service Management**.

3. Under **Analytics and Insights**, select **Settings**. The **Analytics and insights settings** page is displayed.

    > [!div class=ms-imgBorder]
    > ![Customer Service analytics installation](media/cs-enable-analyticsinsights.png "Enable Customer Service historical analytics")

4. On the right side of **Customer Service historical analytics (preview)**, select **Manage**.

5. On the **Customer Service historical analytics** page, toggle **Status** to **Enabled**.

6. Select **Save** or **Save & Close**.

This configuration will enable AI-discovered topics from cases with default settings.


### View Customer Service analytics reports

The service managers must have the admin or service manager role to view the reports. Users with the CSR Manager role will be able to view the reports only after the reports are shared with them.

You can see the following reports by navigating to the **Service** > **Analytics and Insights** > **Customer Service historical analytics (preview)** page. By default, the **Summary** page is displayed.

- [Summary report](summary-dashboard-cs.md)
- [Agent report](agent-dashboard-cs.md)
- [Topics report](topics-dashboard-cs.md)


### See also

[Introduction to Customer Service analytics and insights](introduction-customer-service-analytics.md)  <br>
[View and understand Customer Service analytics and insights in Customer Service Hub](customer-service-analytics-insights-csh.md)  <br>
[View and understand Customer Service analytics](customer-service-analytics.md)  
