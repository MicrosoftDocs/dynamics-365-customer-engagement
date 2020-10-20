---
title: "Configure Customer Service insights for Dynamics 365 in Customer Service Hub and Customer Service workspace | MicrosoftDocs"
description: "Learn how to configure Customer Service Insights in Customer Service Hub and Customer Service workspace"
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 10/20/2020
ms.topic: article
ms.service: 
  "dynamics-365-customerservice"
ms.custom:

---

# Preview: Configure Customer Service Insights in Customer Service Hub and Customer Service workspace

[!include[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
>
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided "as-is," "with all faults," "as available," and without warranty.
> - This preview feature does not come with technical support and Microsoft Dynamics 365 Technical Support won't be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk. All previews are subject to separate [Terms and Conditions](../legal/supp-dynamics365-preview.md).

## Overview

You can configure the Customer Service Insights reports in Customer Service Hub and Customer Service workspace and share them with service managers, who can then view and analyze the different activities performed. The following reports are available out of the box:

- **Insights reports:** Customers can view Customer Service Insights reports with a combination of BI analytics and AI insights for their organization. The reports use natural language understanding to automatically detect the language used in your support cases and group related support cases into topics.

The following historical reports are available:

- **Summary**  
- **Agent**
- **Topics** 
- **Knowledge search analytics (preview)** 

## Enable Customer Service analytics reports in Customer Service Hub 

Make sure that you have administrator permissions for Dynamics 365.

### Enable Customer Service historical analytics reports

1. Sign in to Dynamics 365 as an administrator, and go to Customer Service Hub.

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

- [Summary report](customer-service-analytics.md#1-summary)
- [Agent report](customer-service-analytics.md#2-agent-and-queue)
- [Topics report](customer-service-analytics.md#3-topics)

### Configure topics from cases

Customer Service historical analytics uses artificial intelligence to automatically group your cases into topics using natural language understanding. Topics enable you to discover and adapt to current and emerging trends, improve brand sentiment, and identify problem areas. By pinpointing and fixing issues before they impact customers, you can deliver better customer service experiences. 

The AI-driven technology empowers informed decision-making about how to improve resolution rates, reduce wait times, and decrease customer service costs. You can use case resolution insights, backlog trends, and historical comparisons to evaluate agent performance and business impact, and address inefficiencies in your system.

#### Enable topic clustering for cases

1. Sign in to Dynamics 365 as an administrator, and go to Customer Service Hub.

2. In the **Change area**, select **Service Management**.

3. Under **Analytics and Insights**, select **Settings**. The **Analytics and insights settings** page is displayed.

    > [!div class=ms-imgBorder]
    > ![Customer Service analytics installation](media/cs-enable-analyticsinsights.png "Enable Customer Service historical analytics")

4. On the right side of **Topic clustering for case (preview)**, select **Manage**.

5. On the **Topic clustering for case** page, toggle **Status** to **Enabled**.

6. Select **Save** or **Save & Close**.


#### Summary and Model Run Summary views

   > [!div class=ms-imgBorder]
   > ![Summary and Model Run Summary](media/summary-model-run.png "Summary and Model Run Summary views")

The Summary and Model Run Summary views provide key information about how the topic model is operating.

| View | Description |
|--------|-------------|
| Status | Whether the feature is enabled or disabled.|
| Data attributes used | Which text field from the Case entity is used for topic generation. |
| Topics generated | The total number of topics generated by the model. |
| Cases associated to a topic | The percentage of cases that were considered for topic generation and classified to a topic.|
| Last successful run | Timestamp of the last time new cases were processed. |
| Run frequency | The cadence in which new cases are processed and tagged with topics. |


#### Data mapping

   > [!div class=ms-imgBorder]
   > ![Data mapping](media/data-mapping-cs.png "Data mapping configuration")

Data mapping enables you to choose which text field where agents in your organization are most likely to describe the reason why a customer reached out to support. By default, the Case Title attribute is used, but this setting enables you to select and string attribute in the Case entity.

#### Improve data quality by cleaning support case data

   > [!div class=ms-imgBorder]
   > ![Clean support case data](media/clean-support-case-data-cs.png "Clean support case data to improve data quality")

Customer Service Insights uses artificial intelligence technology to give you insights into your customer service data by grouping support cases as topics that are a collection of related cases. This can help you identify areas for improvement that can have the greatest impact on system performance. 

The AI Insights charts displayed on the Customer Service Insights dashboards are generated by applying language understanding technology to the titles of support cases. However, the results can be misleading if the titles include extraneous information such as product name, case status, or ticket number tags. You can improve the quality of the results displayed in AI Insights charts by specifying Data Cleaning settings to disregard tags in titles when they are grouped into topics, as well as specific phrases that should be ignored. Note that when you choose to apply both options, sections are ignored first, followed by phrases. 


#### Language availability for topics 

The topics capability in the Customer Service historical analytics reports comes with a natural language understanding model that can understand the text semantics and intent in the following languages: 

- English 
- French 
- German 
- Italian 
- Japanese 
- Portuguese 
- Simplified Chinese 
- Spanish 

The language-specific models enable better language understanding capability for the corresponding languages. When Customer Service Insights refreshes your workspace and processes the case data, it will automatically detect the primary languages used in your cases. 

If more than 70% of the cases are in languages supported by a specific language model, that model will be used to discover topics from all of your cases; otherwise, a mixed-language model is used. 

For example, if you have more than 70% of cases detected in English, the English language model will be used to process all of your cases. If more than 70% of your cases are in Spanish, or most in Spanish with some English cases (since all language models have the capability to process English), the Spanish model will be used to process all of your cases.

If you have questions, find issues, or have general inquiries, please refer to our [forum](https://community.dynamics.com/365/aicustomerservice/f/dynamics-365-customer-service-insights).


### Enable Knowledge search analytics (preview)

1. Sign in to Dynamics 365 as an administrator, and go to Customer Service Hub.

2. In the **Change area**, select **Service Management**.

3. Under **Analytics and Insights**, select **Settings**. The **Analytics and insights settings** page is displayed.

    > [!div class=ms-imgBorder]
    > ![Enable knowledge search analytics](media/cs-enable-analyticsinsights.png "Enable knowledge search analytics")

4. On the right side of **Knowledge search analytics (preview)**, select **Manage**.

5. On the **Knowledge search analytics (preview)** page, toggle **Status** to **Enabled**.

6. Select **Save** or **Save & Close**.


### View Customer Service knowledge search analytics (preview) reports

The service managers must have the admin or service manager role to view the reports. Users with the CSR Manager role will be able to view the reports only after the reports are shared with them.

You can see the following reports by navigating to the **Service** > **Analytics and Insights** > **Knowledge search analytics (preview)** page. Search term insights are displayed.


### See also

[Introduction to Customer Service analytics and insights](introduction-customer-service-analytics.md)  
[View and understand Customer Service analytics and insights in Customer Service Hub](customer-service-analytics-insights-csh.md)  
[View and understand Customer Service analytics](customer-service-analytics.md)  
