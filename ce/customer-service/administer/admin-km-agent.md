---
title: Manage Customer Knowledge Management Agent
description: Learn how to manage the Customer Knowledge Management Agent to autonomously create knowledge articles from cases and related communications.
author: Soumyasd27
ms.author: sdas
ms.reviewer: Soumyasd27
ms.topic: how-to
ms.collection:
ms.date: 10/24/2025
ms.custom: bap-template
---

# Manage Customer Knowledge Management Agent

Customer Knowledge Management Agent lets you autonomously turn cases and case-related conversations, emails, and notes into knowledge articles that can support your contact center operations. 

## Prerequisites

- You're using the out-of-the-box case or conversation entities.
- [Dynamics 365 knowledge management](set-up-knowledge-management-embedded-knowledge-search.md#configure-knowledge-management) is configured.
- You enabled Copilot to access Dynamics 365 knowledge base. You can utilize the internal knowledge base resources only for generating responses. Learn more in [Configure knowledge sources](copilot-enable-help-pane.md#configure-knowledge-sources).
- For real-time knowledge creation, you [configured connection references for Customer Knowledge Management Agent flow](admin-km-agent-connections.md#configure-connection-references-for-customer-knowledge-management-agent-flow)
- You [set up pay-as-you-go](setup-pay-as-you-go.md#set-up-pay-as-you-go).

## Enable Customer Knowledge Management Agent

In Copilot Service admin center, go to **Support experience** > **Knowledge** > **Customer Knowledge Management Agent**, and then select **Manage**. The **Customer Knowledge Management Agent** page appears.

You can harvest knowledge articles from cases, conversation summaries associated to the cases, emails, notes, and conversations. For cases and conversations, select from the options in the following sections as required for Customer Knowledge Management Agent.

## Enable real-time knowledge creation

- For cases, go to the **Case** tab, and in the **Real-time creation** section, select the **Let Copilot use information from current case to create knowledge articles** option. 

- For conversations, go to the **Conversations** tab, and in the **Real-time creation** section, select the **Let Copilot use information from current chat and messaging conversations to create knowledge articles** option.

Real-time knowledge creation is triggered when a customer service representative (service representative) resolves a case or closes a conversation. The agent determines whether a new knowledge article is needed by comparing the content of the case or conversation with the existing knowledge articles in Dynamics 365 knowledge base. If an article is required, the Customer Knowledge Management Agent creates the article using the case or conversation content.  

### Manage rules for real-time article creation  

You can create multiple rules to specify the conditions that must be met for a resolved case or closed conversation to be processed by Customer Knowledge Management Agent in real time. For example, you might limit this process to cases or conversations owned by a certain user, or any other fields on the case or conversation. 

1. From the **Case** or **Conversations** tab, in the **Real-time creation** section, select **Manage rules**. 
1. In the **Manage rules** dialog, select **New** to add a new rule.
1. In the **New knowledge creation rules** dialog, enter a rule name, condition name, and then add your conditions.
1. Select **Save**.

### Manage case attributes used to create knowledge articles

Customer Knowledge Management Agent uses **Case Title**, **Case Description**, **Product**, **Subject**, **Email Content**, **Conversation Summary**, and **Case Notes** to create an article. You can modify all the fields except **Email Content** and **Conversation Summary**. You can't change the attributes used for conversations.
 
1. In the **Case** section, select **Manage attributes**. The **Manage data** page appears. 
You can map which record types and data fields are used for each element. You can choose to include and exclude data.
1. Select **Save and Close**.
1. Select **Save** on the **Customer Knowledge Management Agent** settings page.

Case attribute selections are applicable to both historical and real-time creation from cases. 

### Enable track changes and add mapped entities to the Entity Analytics Config table

To avoid issues during knowledge article creation from historical data, we recommend that you enable **Track changes** for the mapped entities and add them to the **Entity Analytics Config** table .

1. [Enable track changes](/power-platform/admin/enable-change-tracking-control-data-synchronization#using-power-apps-settings)
2. To add mapped entities to the **Entity Analytics Config** table:
    
    1. Open the model-driven app ( `https://<org>.crm.dynamics.com/...` ).   
    2. Press **F12** to open the browser’s **Developer Tools**, and then select the **Console** tab.   
    3. Copy the following script snippet, update **ENTITY_NAME**, and paste it into the console.
    4. Press **Enter** to run the script.
    
    ```javascript
    
    Xrm.WebApi.createRecord('entityanalyticsconfig', {'parententitylogicalname':'{ENTITY_NAME}','isenabledforadls': true})
    
     ``` 

## Enable historical knowledge creation

When enabled, the agent considers all the cases and conversations that meet the specified conditions and then determines if new articles are needed by comparing the content of the cases or conversations with the existing knowledge base. The agent then creates a new article, if required, based on the content of the cases and conversations.

1. Select the **Cases** or the **Conversations** tab.

    ### [Case](#tab/case)
    a. In the **Creation from historical cases** section, select the **Let copilot use information from historical cases to create knowledge articles** option.
    ### [Conversations](#tab/conversations)
    a. In the **Creation from historical conversations** section, select the **Let copilot use information from historical chat and messaging conversations to create knowledge articles** option.
    ### [Custom record types (preview)](#tab/Custom record types)
    a. In your custom record type section, select the **Let copilot use information from historical custom record types to create knowledge articles** option.

1. Select **Manage rules** to configure the conditions for the harvest.
1. On the **Default rule** dialog, enter a rule name, condition name, and then add your conditions to filter historical articles. You may also specify a custom article template to be used for this rule. 
1. Select **Save**.
1. Select **Save** on the **Customer Knowledge Management Agent** settings page.
1. Select **Start** on the **Creation from historical cases, conversations, or custom record types** section. 
Once you select start, you see that the article creation is in progress. You can see the creation process log by selecting the **View creation process log** link.

Historical case or conversation creation is a long-running process that can't be stopped once it starts. The process can create articles from up to 100,000 individual cases or conversations and continues until all are processed. We recommend performing historical knowledge creation in batches. 

## Specify a custom article template for historical knowledge creation 

When you set up historical creation rules, you can choose a custom article template for new articles. By default, Customer Knowledge Management Agent creates articles in **Issue**, **Cause**, and **Resolution** format. If you have [configured knowledge article templates](../use/create-templates-knowledge-article.md#create-templates-for-knowledge-articles), you can specify one template per rule. 

When you specify a custom article, Customer Knowledge Management Agent uses the template sections, section instructions, and styles to create the new article. Use the following best practices for your template: 

- Include only content sections in the template; exclude metadata fields (for example, avoid fields like Article Creation Date).
- Provide a detailed description for each section, explaining the type of content expected.
- Clearly indicate which fields are required and which are optional within the template.
- If categorization is needed, include the list of category options directly in the template.
- Clearly separate any compliance text (for example, add a note such as “Do not edit below this line.”).
- Use a consistent format for placeholders and variables, such as {{ProductName}} or {{ErrorCode}}.
- Where possible, include a minimal, well-structured example within the template to guide users.

## Add custom record types (preview)

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

You can add custom record types that Customer Knowledge Management Agent can use to create new knowledge articles. Currently, these custom record types are supported only for historical article creation. 

To add a custom record type: 

1. [Turn on knowledge management for your record type](configure-knowledge-search-control-productivity-pane.md#add-record-types-for-which-you-want-to-turn-on-knowledge-management).
1. In Copilot Service admin center, go to **Support experience** > **Knowledge** > **Customer Knowledge Management Agent**, and then select **Manage**. The **Customer Knowledge Management Agent** page appears.
1. Select **Add record type**. The **Add record type** page appears. 
1. In the **Select record type** dropdown, select the record type you wish to create knowledge from.
1. Select **Save and close**.

You may add up to five custom record types. 

## Manage additional record type attributes used to create knowledge articles
Customer Knowledge Management Agent uses **Title**, **Description**, **Product**, **Subject**, **Email Content**, and **Case Notes** to create an article. You can modify all the fields except **Email Content**, **Incident Resolution** and **Conversation Summary**. 
 
1. In your custom record type section, select **Manage attributes**. The **Manage data** page appears. 
You can map which record types and data fields are used for each element. You can choose to include and exclude data.
1. Select **Save and Close**.
1. Select **Save** on the **Customer Knowledge Management Agent** settings page. 

## Configure automatic article updates (preview)

[!INCLUDE [preview-banner](../../../shared-content/shared/preview-includes/production-ready-preview-dynamics365.md)]

Customer Knowledge Management Agent can automatically apply minor updates to existing knowledge articles. By default, Customer Knowledge Management Agent creates a new minor version of the article.

To enable automatic minor updates of articles, on the **Customer Knowledge Management Agent** page, in the **Automatic article updates** section, select the **Automatically update existing articles (preview)** option.


## Set the default compliance state of created articles

You can set the default compliance state for articles and their updated versions, created by the Customer Knowledge Management Agent. For example, to maintain compliance, set the default state to **Pending** and have knowledge reviewers mark the articles as compliant before publishing.  

To set the default compliance state of articles created by Customer Knowledge Management Agent, on the **Customer Knowledge Management Agent** page, **Compliance** section, select your default compliance state from the available options.

Articles with the **Non Compliant** status can't be published.

> [!NOTE]
> Customer Knowledge Management Agent removes personal data from the case data before drafting articles. However, the agent might not detect all instances of sensitive information.

## Auto publish articles

You can configure whether the AI agent can automatically publish articles and minor updates that meet the specified **Compliance** status. You can also select the target audience that can view the published articles.

To set the auto-publishing of articles created by Customer Knowledge Management Agent, on the **Customer Knowledge Management Agent** page, **Auto publishing** section, select the **Automatically publish compliant articles as soon as they’re created** option.

- Select **Internal target audiences**, if you want articles to be available to your service representatives and Copilot internally. 
- Select **Internal and external target audiences**, if you want these articles to be published to external portals.

## Set up the agent review draft experience

If you’re not configuring the AI agent to automatically publish articles, you can configure an agent review experience where service representatives can review and publish articles.

To enable this editor: 

- Enable in-app notifications for service representatives to be notified when their cases are considered for publishing.
- Ensure that your service representatives have the permission to edit articles.
- Make sure that your cases have **Timeline** and **Timeline highlights** enabled.

Service representatives can see whether they have knowledge articles to review by opening a resolved case. Learn more in [Review knowledge articles created by the Customer Knowledge Management Agent](../use/admin-km-agent-review.md#review-knowledge-articles-created-by-the-customer-knowledge-management-agent).

## Use knowledge insights for Customer Knowledge Management Agent

You can get analytics reports on Customer Knowledge Management Agent and collect analytics data for your own custom reporting. Learn more in [Use knowledge insights for Customer Knowledge Management Agent](../use/admin-km-agent-insights.md#use-knowledge-insights-for-customer-knowledge-management-agent).

## Related information

[Review knowledge articles created by the Customer Knowledge Management Agent](../use/admin-km-agent-review.md#review-knowledge-articles-created-by-the-customer-knowledge-management-agent)  

[Use knowledge insights for Customer Knowledge Management Agent](../use/admin-km-agent-insights.md#use-knowledge-insights-for-customer-knowledge-management-agent)
