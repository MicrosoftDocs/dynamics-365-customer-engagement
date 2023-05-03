---
title: Frequently asked questions about Sales Premium
description: Get answers to frequently asked questions about Dynamics 365 Sales Premium.
ms.date: 03/28/2023
ms.custom: bap-template
ms.topic: faq
author: udaykirang
ms.author: udag
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
---

# Frequently asked questions about Sales Premium

## Licenses and storage

### What's the difference between Sales Premium and Sales Insights?  

Sales Premium refers to the license and Sales Insights refers to the capabilities. The Sales Premium license includes both Sales Enterprise and Sales Insights capabilities. The basic Sales Insights capabilities are also available with the Sales Enterprise license. For a detailed comparison of the capabilities in each license, go to the **Compare Dynamics 365 Sales plans** section on the [Pricing](https://dynamics.microsoft.com/sales/pricing/) page.  

### Where can I find the comparison chart for Dynamics 365 Sales licenses?

The following license options are available for Dynamics 365 Sales:

- Sales Premium
- Sales Enterprise
- Sales Professional

For a detailed comparison of capabilities available with each license, go to the **Compare Dynamics 365 Sales plans** section on the [Pricing](https://dynamics.microsoft.com/sales/pricing/) page.

### After I installed Sales Insights, I see a spike in the data usage. How much storage data does Sales Insights need?  

When you install Sales Insights, corresponding analytics tables are created for contacts, opportunities, leads, accounts, and activity party tables. The storage requirement for these analytics tables is directly proportional to the amount of data in Dataverse. The tables are stored as files in the managed data lake and are counted against your total file storage quota. For more information, see [New Microsoft Dataverse storage capacity](/power-platform/admin/capacity-storage).

## General

### In which country/region is Sales Premium available?

Sales Premium is available in the following countries/regions:

- Asia Pacific (APJ)
- Canada (CAN)
- Europe, the Middle East, and Africa (EMEA)
- France (FRA)
- Great Britain (GBR)
- India (IND)
- Japan (JPN)
- North America (NAM)
- Oceania (OCE)
- South Africa (ZAF)
- South America (SAM)
- Switzerland (CHE)  
- United Arab Emirates (UAE)

> [!NOTE]
> Sales Premium isn't available in the following datacenters: Germany, Korea, Norway, Government Community Cloud (GCC), including USG, Department of Defense (DoD), and China.

### In which country/region are the features available?

Sales Premium features are available in the following countries/regions:

| Feature | NAM | EMEA | GBR | APJ | CAN | IND | JPN | OCE | CHE | FRA | SAM | ZAF | UAE |
|---------|-----|------|-----|-----|-----|-----|-----|-----|-----|-----|-----|-----|-----|
| Assistant | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Auto capture | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Conversation intelligence | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Notes analysis | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Premium forecasting | Yes | Yes | Yes | Yes | Yes | No | Yes | Yes | Yes | No | Yes | Yes | Yes |
| Predictive lead scoring | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Predictive opportunity scoring | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Relationship analytics | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes |
| Sales accelerator | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes | Yes|
| Who knows whom | Yes | Yes | No | Yes | Yes | No | No | No | No | Yes | No | No | No |

### Which version of Exchange is supported for features in Sales Premium?

The Sales Premium features support the following versions of Exchange:

| Feature | Exchange Online | Exchange Server 2013 and above | Is Exchange required? |
|---------|-----------------|--------------------------------|-----------------------|
| Relationship analytics and health | Yes | No | No |
| Assistant | Yes | No | No |
| Email engagement | Yes | Yes | Yes |
| Who knows whom | Yes | No | Yes |

>[!NOTE]
>
>- The assistant and relationship analytics can work without Exchange. However, the information displayed in relationship analytics doesn't contain Exchange data and the assistant doesn't display cards that are based on Exchange data.
>- For relationship analytics, support for Exchange Online is available only in North America (NAM) and Europe, the Middle East, and Africa (EMEA).
>- For who knows whom, the organization's Office 365 data location must be one of the following and not your region-specific datacenter location:
>   - Global Geography 1 – EMEA (Austria, Finland, France, Ireland, Netherlands)
>   - Global Geography 2 – Asia Pacific (Hong Kong, Japan, Malaysia, Singapore, South Korea)
>   - Global Geography 3 – Americas (Brazil, Chile, United States).
>
> [Learn more about datacenter locations](/microsoft-365/enterprise/o365-data-locations?view=o365-worldwide#data-center-locations&preserve-view=true).

### What languages are supported?

Sales Premium supports the following languages:

| Feature | Language supported |
|---------|--------------------|
| Assistant, assistant studio, auto capture, email engagement, predictive lead scoring, predictive opportunity scoring, premium forecasting, relationship analytics, sales accelerator, and who knows whom | Arabic, Basque, Bulgarian, Catalan, Chinese Simplified (PRC), Chinese Traditional (Hong Kong SAR), Chinese Traditional (Taiwan), Croatian, Czech, Danish, Dutch, English, Estonian, Finnish, French, Galician, German, Greek, Hebrew, Hindi, Hungarian, Indonesian, Italian, Japanese, Kazakh, Korean, Latvian, Lithuanian, Malay, Norwegian, Polish, Portuguese (Brazil), Portuguese (Portugal), Romanian, Russian, Serbian (Cyrillic), Serbian (Latin), Slovakian, Slovenian, Spanish, Swedish, Thai, Turkish, Ukrainian, and Vietnamese |
| Notes analysis | English, French, German, Italian, and Dutch for machine learning models |
| Exchange insight cards in assistant | Only English - United States (en-US) for machine learning models |
| Activity-content-based auto capture | For activity suggestions, the body of emails and meetings are analyzed in English, French, German, Italian, Dutch, and Norwegian |
| Conversation intelligence | Go to [Languages supported for conversation intelligence](language-support-conversation-intelligence.md) |

[Learn more about infrastructure availability](https://aka.ms/dynamics_365_international_availability_deck).

### Where is my organization's data stored?  

Depending on the country/region where your organization is hosted, data is stored in the following locations:

| Region | Primary Azure datacenter location  | Secondary Azure datacenter location |
|--------|-------------------------------------|--------------------------------------|
| Asia Pacific (APJ) | South East Asia (Singapore) | East Asia (Hong Kong SAR) |
| Canada (CAN) | Canada Central (Toronto) | Canada East (Quebec City) |
| Europe, the Middle East, and Africa (EMEA) | West Europe (Netherlands) | North Europe (Ireland) |
| France (FRA) | France Central (Paris) | -- |
| Great Britain (GBR) | UK South (London) | UK West (Cardiff) |
| India (IND) | Central India (Pune) | South India (Chennai) |
| Japan (JPN) | Japan East (Tokyo, Saitama) | Japan West (Osaka) |
| North America (NAM) | East US (Virginia) | West US 2 (Washington) |
| Oceania (OCE) | Australia East (New South Wales) | Australia Southeast (Victoria) |
| South America (SAM) | Brazil South | Brazil Southeast |
| Switzerland (CHE) | Switzerland North | Switzerland West |

[Learn more about Azure regional pairs](/azure/best-practices-availability-paired-regions#azure-regional-pairs).

### Which users can push data from Dynamics 365 Sales to Dataverse?

Dynamics 365 Sales data is pushed to Dataverse to generate insights like predictive scoring, relationship analytics, who knows whom, and predictive forecasting. A set of predefined [system and application users](/power-platform/admin/system-application-users) may push data from Dynamics 365 Sales to Dataverse.

### Why are my entities updated by some application users?

System and application users update certain entities with insights about the records. For example, the application users update lead and opportunity entities to add predictive scores. Similarly, contact, opportunity, lead, and account entities are updated with relationship KPIs and analytics. [Which users can push data from Dynamics 365 Sales to Dataverse?](#which-users-can-push-data-from-dynamics-365-sales-to-dataverse)

## Digital sales

### What digital sales capabilities are included with Dynamics 365 Sales?

If you have a Dynamics 365 Sales Enterprise, Microsoft Relationship Sales, or Customer Engagement plan, you can start using three Dynamics 365 Sales Premium features to enhance your digital selling programs: conversation intelligence, sales accelerator with sequences, and predictive scoring. Capacity is limited. [Learn more about digital selling capabilities in Sales Enterprise](digital-selling.md).

### What's the capacity limit on digital sales?

When you use Sales Premium features as part of your Dynamics 365 Sales Enterprise license, the following capacity limits apply:

- Sales accelerator provides access to the workspace and up to 1,500 records connected to any defined sequence per environment per month. Manual activities that aren't connected to a sequence are displayed without a capacity limit.
- Each user can access up to three hours of conversation intelligence per month.
- Sellers can view up to 1,500 leads or opportunity records scored per environment per month with predictive scoring.

### How can I get the full capacity of digital sales?

If you need more capacity, [upgrade to Dynamics 365 Sales Premium](https://dynamics.microsoft.com/sales/pricing/).

## Assistant

### Why am I getting an insufficient permissions alert when I use an insight card?

You need more permissions than you have. Here's how to fix it:

1. Go to **Settings** > **Security** > **Security Roles**.
1. Select the role of the user who's viewing the insight card.
1. Select the **Core Records** tab.
1. Set the privileges to Read and Write access for **Action card** and **Action Card User Settings**.  

    :::image type="content" source="media/action-card-permissions600.png" alt-text="Screenshot of the insight card security role settings.":::

### Why am I getting a "contact administrator" error when I authenticate my credentials in assistant studio?

The error is caused by your organization's policies to restrict third-party tools to access user information. To resolve the issue, provide consent for yourself through the [Azure portal](https://portal.azure.com) for third-party tools to access your data. Select the enterprise application as **Dynamics 365 Sales Insights**. To provide consent for the entire organization, contact your tenant administrator. [Learn how to grant admin consent in Enterprise apps](/azure/active-directory/manage-apps/grant-admin-consent#grant-admin-consent-in-enterprise-apps).

## Sales accelerator

### How do I add the up next widget to an entity form?

You can add the **Up next** widget only to managed entity forms.

#### Create a solution

1. Go to **Settings** > **Solutions**, and then create an empty solution; for example, **AddWidget**.  
1. Add a **Form** to the solution.  
1. Save the changes and publish the customizations.
1. Export the created **AddWidget** solution as **UnManaged**.
1. Delete the solution **AddWidget** from the organization.
1. Extract the zip file of the downloaded solution.

#### Modify the XML files

1. In the file `solution.xml`, change the `<Managed>` value to **1**.
1. In the `customizations.xml` file, delete the parameter `<systemform unmodified="1">`.
1. On the **Summary** tab, select the `<column>` where you want to add the widget.
1. Add the `<section>` tag as follows:

    ```xml
    <section name="CadenceWidget" showlabel="false" showbar="false" id="{<NEW_GUID_G1>}" IsUserDefined="0" layout="varwidth" columns="1" labelwidth="115" celllabelalignment="Left" celllabelposition="Left" labelid="{<NEW_GUID_G2> }">
      <labels>
          <label description="Cadence Widget" languagecode="1033" />
      </labels>
      <rows>
          <row>
              <cell id="{<NEW_GUID_G3>}" showlabel="false" colspan="1" rowspan="6" labelid="{<NEW_GUID_G4> }">
                  <labels>
                      <label description="Cadence widget" languagecode="1033" />
                  </labels>
                  <control id="CadenceWidgetControl" classid="{F9A8A302-114E-466A-B582-6771B2AE0D92}"  uniqueid="{<NEW_GUID_G5>}" isunbound="true">
                      <parameters />
                  </control>
              </cell>
          </row>
          <row />
          <row />
          <row />
          <row />
          <row />
      </rows>
    </section>
    ```

1. Replace all the `<NEW_GUID_G>` occurrences by generating a new GUID for each place.
1. In the `<controlDescriptions>` node, add a child node:

    ```xml
    <controlDescription forControl="{<GUID_G5>}">
    <customControl formFactor="2" name="MscrmControls.AcceleratedSales.CadenceWidgetControl">
        <parameters />
    </customControl>
    <customControl formFactor="0" name="MscrmControls.AcceleratedSales.CadenceWidgetControl">
        <parameters />
    </customControl>
    <customControl formFactor="1" name="MscrmControls.AcceleratedSales.CadenceWidgetControl">
        <parameters />
    </customControl>
    </controlDescription>
    ```

1. Replace the ```<GUID_G5>``` in ```customizations.xml``` with the **GUID_G5** generated from **step 11**.
1. Save the changes and zip the folder.

#### Add the widget to the form

1. Open Dynamics 365 and go to **Settings** > **Solutions**.
1. Import the zipped solution.
1. Publish all customizations.
1. Verify that the **Up next** widget appears on the form.

### How do I add the sales accelerator site map to my custom app?

Use the site map designer in the app designer to [add the sales accelerator site map to your custom app](add-sales-accelerator-sitemap-entry-custom-app.md).

## Relationship analytics and health

### Which data is used to generate basic relationship insights?

**Basic insights:** Uses email, phone call, and appointments sent or received in Dynamics 365.

**Enhanced insights:** Uses email, phone call, and appointments sent or received in Dynamics 365 and Exchange (if configured).

### How often are KPIs updated?

**Basic insights:** Updated in near real-time&mdash;as soon as a related activity is marked as completed in Dynamics 365.  

**Enhanced insights:** Updated every 24 hours. ​  

### What are the signals in relationship health?

​Relationship health looks at activity, recency, engagement, and sentiment of activities between sellers and customers.

### Is the Office 365 consent mandatory for the relationship intelligence feature to work?

Office consent isn't mandatory for relationship analytics, health score, and who knows whom. You get basic relationship insights based on the data in Dynamics 365. When you provide consent in Office 365 to use Exchange data, you get more accurate and complete relationship information.

### What happens if I select the Exchange checkbox but the Office 365 admin hasn't provided consent?

The data from Exchange isn't collected until consent is provided. Work with your Office 365 administrator to [get consent to collect data from Office 365](provide-consent-office365.md).

### Why is the Exchange option selected although I didn't select it or provide the required consent?

Relationship intelligence has the Exchange option selected by default. However, no data is collected from Exchange until your Office 365 administrator provides consent. You can clear the option if you aren't planning to integrate with Exchange.
  
### Can I influence the relationship health score?​

An administrator can influence the relationship health score by changing the weight of activity types and the expected level of communications with customers. [Learn how to configure relationship analytics and health](configure-relationship-analytics.md).

### How are similar won deals identified? <a name="similar-won-deals-fields"></a>

Dynamics 365 Sales uses AI models to determine the factors that affect the identification of similar won deals. The factors may differ from organization to organization based on custom and out-of-the-box fields.

To view the fields that determine the similar won deals at that point in time, select the information icon corresponding to any section heading and a side pane opens with the field information.

## Predictive lead/opportunity scoring

### What do I need to use lead/opportunity scoring?​

Install Dynamics 365 Sales Insights and use the standard lead entity or the standard opportunity entity.​  

- You must have a minimum of 40 qualified and 40 disqualified leads to build a lead score model.  
- You must have a minimum of 40 won and 40 lost opportunities to build an opportunity scoring model.  
- The leads and opportunities must have been created on or after January 1 of the previous year.

### How often are the predictive scores updated?

**Lead scores:** For new leads, the scoring happens in near real-time. The score is displayed within five minutes of saving a new lead. For updated leads, the scores are refreshed every 24 hours.

**Opportunity scores:** For new and updated opportunities, the scores are refreshed every 24 hours.

### Why aren't my leads scored in real-time?

Real-time scoring is supported only for new leads. If you don't see the score 15 minutes after saving or importing the new lead, contact your administrator. Your administrator can verify whether the model that's scoring the new lead was created or edited and published after the real-time scoring feature was rolled out. [Learn more about real-time scoring](work-predictive-lead-scoring.md#real-time-scoring).

### Can I customize the model?

You can modify which attributes are selected to train the model. That said, the out-of-the-box model automatically selects the attributes it determines are most relevant for your business.

### Can I create multiple models for leads/opportunities?​

You can add and publish multiple models that are specific to each line of business in your organization.

### What's the difference between a score and a grade?​

The score is generated by the machine learning model. The grade is just grouping scores in four buckets that your admin can configure.

## Notes analysis

### What does notes analysis look at for the intent?​

Notes analysis looks at notes and posts on the timeline for the intent that may indicate a record should be created. Timeline posts include meeting requests, meetings, tasks, and contacts.

## Auto capture

### How long does the application take to display captured suggestions?

For activities, the suggestions are displayed immediately.  

## Who knows whom

### Why am I not seeing some of my colleagues in the suggestions?

If you know that a colleague has interacted with a customer but their information isn't shown in the who knows whom widget, it could be for the following reasons:

**Basic insights:** Displays the five colleagues who contacted the customer the most through emails and appointments in Dynamics 365. Colleagues who contacted the customer by phone and those who had fewer interactions through emails and appointments aren't listed.

**Enhanced insights:**

- Those colleagues aren't part of your Dynamics 365 org.
- Those colleagues aren't part of the security role that's [enabled for relationship intelligence](enable-ri.md).  
- Those colleagues are part of the security group that your Office 365 admin has [opted out](provide-consent-office365.md).
- Those colleagues have explicitly [opted out of sharing their data](who-knows-whom.md#turn-off-data-sharing-with-dynamics-365-applications).

[Which colleagues show up as connections?](#which-colleagues-show-up-as-connections)

### How long does it take for suggestions to show up?

**Basic insights:** Who knows whom suggestions are available out-of-the-box if the email and appointment data is available in Dynamics 365.

**Enhanced insights:** After your Microsoft 365 admin provides consent, you'll start seeing results within a day. They may not be complete right away, because the data is processed in batches over four days.  

### Which colleagues show up as connections?

**Basic insights:** Colleagues who have contacted the customer the most through emails and appointments in Dynamics 365.

**Enhanced insights:** Users in your org who have frequently and recently interacted with the contact or lead show up as connections, unless they've [opted out of sharing data with Dynamics 365](who-knows-whom.md#turn-off-data-sharing-with-dynamics-365-applications). Administrators can [opt out groups](provide-consent-office365.md) such as C-suite, M&A, finance, and so on.

### How are the connections weighted?

**Basic insights:** By frequency. Connections are weighted based on the number of interactions through emails and appointments in Dynamics 365. The five users who have interacted the most with the contact or lead are displayed.  

**Enhanced insights:** By frequency and recency. If your administrator has enabled Exchange integration, connections are weighted based on recent and frequent interactions through emails and appointments.

Every seller sees the same set of introducers for a contact or lead.

### How frequently is the data collected?

**Basic insights:** Collected in near real-time, as soon as a related activity is marked as completed in Dynamics 365.  

**Enhanced insights:** When you enable who knows whom and provide the required consent, Exchange data pertaining for last year is collected and insights are generated based on that data. After this, Exchange data is collected daily and insights are updated based on the latest data.  

### What is the source for who knows whom data?

**Basic insights:** Emails and appointments sent and received in Dynamics 365.

**Enhanced insights** Emails and meeting information in Exchange Online. [Learn more about how connections are weighted](#how-are-the-connections-weighted).

### Where are the insights from Exchange generated?

After the Microsoft 365 admin provides consent, the Exchange data is collected and stored in Dynamics 365. The insights are then generated from the stored data in Dynamics 365.  

> [!IMPORTANT]
> Microsoft 365 and Dynamics 365 each have their own service-specific licensing terms. The service-specific terms that apply depend on which service processes your data. For example, when a copy of your Microsoft 365 data is transferred to Dynamics 365, your Microsoft 365 data in that copy becomes Dynamics 365 data and the Dynamics 365 service-specific terms apply.

### When will my data be removed after I opt out of data sharing in Exchange?

If you're part of a security group that has been opted out by your administrator, the system can take up to 24 hours to remove data from all apps and up to 30 days to remove backed-up data from Microsoft 365 storage accounts.  

If you've [opted out on your own](who-knows-whom.md#turn-off-data-sharing-with-dynamics-365-applications), the data is removed immediately.  

### How can an administrator opt out users?

The following administrators can opt out users at different levels:

- **Microsoft 365 Global administrator** can opt out users of a Microsoft 365 security group like C-suite, M&A, finance, and so on. [Learn how to provide consent to collect data from Microsoft 365](provide-consent-office365.md).

- **Dynamics 365 administrator** can enable who knows whom for specific security roles to avoid opting in all Dynamics 365 users automatically. When you enable it for a specific role, the Exchange data is collected only from users who are part of the security role. [Learn how to enable relationship intelligence](enable-ri.md).

## Conversation intelligence

### Which conversation intelligence features are available in Dynamics 365 Sales versus Viva Sales?  

| Feature | Viva Sales | Sales Enterprise/Sales Premium |
|---------|---------|---------|
| **Call processing** |
| Conversation intelligence for phone calls from Teams (inbound/outbound) | No | Yes<sup>1</sup><br><sup>1</sup> **Sales Enterprise:** Three hours of conversation intelligence (recording and processing) per user, per month<br>**Sales Premium:** 10 hours of conversation intelligence (recording and processing) per user, per month. To get more hours, [buy the Conversation Intelligence add-in](/microsoft-365/commerce/buy-or-edit-an-add-on#buy-an-add-on). |
| Conversation intelligence for Teams meetings | Yes (unlimited) | Yes<sup>1,2</sup><br><sup>1</sup> Use the Viva Sales app for Teams<br><sup>2</sup> Unlimited Viva Sales hours included with the Sales Premium/Sales Enterprise license |
| **During the call** |
| Real-time conversation intelligence | No | Yes |
| Conversation intelligence for seller-only recordings (when the customer isn't recorded) | No | Yes |
| **After the call** |
| Log conversation summary and details in the CRM record | No | Yes |
| Edit and share a conversation summary | No | Yes |
| Schedule an action item from a conversation summary | No | Yes |
| Aggregate dashboards for managers | No | Yes |
| Manager coaching tools | No | Yes |
| **Admin configuration** |
| Storage of call recording and conversation intelligence insights | Teams storage only | Option of Microsoft storage or your own Azure storage |
| Supported languages for conversation intelligence | [Supported languages in Viva Sales](/viva/sales/supported-languages) | [Supported languages in Sales Premium](faqs-sales-insights.md#what-languages-are-supported) |
| Supported languages for UI | [Supported languages in Viva Sales](/viva/sales/supported-languages) | All languages supported in Dynamics 365 Sales |

### How long does it take for data updates to reflect in the app?

The data is refreshed periodically and can take up to 12 hours to be reflected in the app.

### How many hours of conversation intelligence are available with Viva Sales?

You get unlimited call recording and processing hours with Viva Sales. You must create the meeting in Outlook and turn on **Teams meeting** to get conversation intelligence through Viva Sales. [Learn how to use Viva Sales in Teams](https://support.microsoft.com/topic/use-viva-sales-in-teams-04286b82-bdf8-4e37-94ce-be1943b2d6ea).  

### How do I buy more conversation intelligence hours?

With the Sales Premium license, you get 10 hours of call recording and processing capacity per user, per month for conversation intelligence. If you need more hours, [buy the Conversation Intelligence add-on](/microsoft-365/commerce/buy-or-edit-an-add-on?view=o365-worldwide&preserve-view=true#buy-an-add-on). For information on the additional hours provided by the add-on, see the [licensing guide](https://go.microsoft.com/fwlink/?LinkId=866544&clcid=0x409).

If you have the Sales Enterprise license, upgrade to the Sales Premium license to buy more hours.  

### Can sellers and nonmanagers use this app?

The application is available for sellers to view their conversational insights.

### Is an admin needed to enable the app for my organization?

An administrator must configure the application for you to use. If an administrator didn't configure the application, you can explore the app with the demo data that's provided.

### Which telephony system do you support?

The application is independent of telephony systems. If you have stereo call recordings (two-channel stereo), we process them at scale to generate insights​.

### What does the onboarding experience include?​

As part of the onboarding experience, you must provide the access key to the Azure blob location where you upload your call recording files for processing. You must adhere to standard metadata format (in JSON) of conversation intelligence and upload that along with every call recording file. You must also share trackers that you care about along with the competitive brands and products for conversation intelligence to track these words across calls.

### How is the sentiment model built?

Conversation intelligence transcribes the calls into text and generates sentiment from the text in the conversation.

### I have mono-channel recording files. Can I still use conversation intelligence?

We **do not** process mono-channel call recording files. We only support stereo-type call recording files.

### How long does it take to see the results?

Conversation intelligence takes a few minutes to process and display the data on the dashboard, depending on the size of the call recording files and format. You must have at least 10 call recording files to process and display the data.

### Do you retain the call recordings?

Call recordings are deleted as soon as the audio file is processed​.

### See also

[Overview of Dynamics 365 Sales](overview.md)  
[Introduction to administering Sales Insights features](intro-admin-guide-sales-insights.md)

[!INCLUDE [footer-include](../includes/footer-banner.md)]
