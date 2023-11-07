---
title: View the Omnichannel real-time analytics reports on customized Customer Service workspace
description: View Omnichannel real-time analytics reports to help customer service managers enhance team performance and improve customer satisfaction.
ms.date: 11/07/2023
ms.topic: article
author: Soumyasd27
ms.author: sdas
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:11/07/2023
---

# View the Omnichannel real-time analytics reports on customized Customer Service workspace

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
>
> This feature is intended to help customer service managers or supervisors enhance their team’s performance and improve customer satisfaction. This feature is not intended for use in making, and should not be used to make, decisions that affect the employment of an employee or group of employees, including compensation, rewards, seniority, or other rights or entitlements. Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, including laws relating to accessing individual employee analytics and monitoring, recording, and storing communications with end users. This also includes adequately notifying end users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.

> [!NOTE]
>  Any visual customizations that you might have made on the preview version will be overwritten when your organization gets upgraded to the latest generally available version. Future updates to the data model will be backward compatible and visual customizations will be retained. More information: [Future data model updates](customize-reports.md#future-data-model-updates)

## View Omnichannel real-time analytics reports

To view the reports in Customer Service workspace, see [Access reports](intro-realtime-analytics-dashboard.md#access-reports).

If you've customized the Customer Service workspace, perform the following steps to be able to view the reports:

1. Go to [make.powerapps.com](https://make.powerapps.com).
1. Select **Apps**.
1. Select **Customer Service workspace** and then select **Edit**.
1. On **Pages**, select **New**.
1. On the **New page** dialog, select **URL** and then select **Next**. Fill in the following information:
    1. **URL**: **/main.aspx?pagetype=control&controlName=MscrmControls.Analytics.ReportingControl&data={"featureIds":"e67a1ada-6c62-4b45-b758-0b246f32c1a5"}**
    2. **Title**: Omnichannel real-time analytics (or any other sub area title you would want to add).
1. Select **Add**.
1. Optionally, on the **Omnichannel real-time analytics** pane, on the **Icon** dropdown list, select **Use web resource**.
1. On the **Select web resource image** dialog, search and select the **msdyn_/Analytics/imgs/RealtimeReportIcon.svg** display name, and then select **Apply**. The **Omnichannel real-time analytics** page gets displayed on Customer Service workspace.
1. Select **Save**, and then select **Publish**.

### See also

[Overview of Omnichannel real-time analytics reports](intro-realtime-analytics-dashboard.md)  
[View and understand the Summary report in Omnichannel real-time analytics](realtime-summary-dashboard.md)  
[View and understand the Voice report in Omnichannel real-time analytics](realtime-voice-dashboard.md)  
[View and understand the Agents report in Omnichannel real-time analytics](realtime-agents-analytics.md)  
[View and understand the Ongoing Conversation report in Omnichannel real-time analytics](realtime-ongoing.md)  
[Use Omnichannel for Customer Service metrics](oc-metrics-dimensions.md#use-omnichannel-for-customer-service-metrics)
[Configure user security to resources in an environment](/power-platform/admin/database-security)  
[How access to a record is determined](/power-platform/admin/how-record-access-determined)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
