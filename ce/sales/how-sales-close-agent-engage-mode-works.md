---
title: How the Sales Close Agent - Engage works
description: Learn how the Sales Close Agent - Engage operates to autonomously manage customer interactions and drive sales for high-velocity, low-complexity deals.
ms.date: 12/17/2025
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-description
  - ai-seo-date:08/04/2025
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# How the Sales Close Agent - Engage works

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

In this section, you learn how the Sales Close Agent - Engage operates to autonomously manage customer interactions and drive sales for high-velocity, low-complexity deals.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## How the records are processed

When the Sales Close Agent - Engage is started, it processes records based on the configuration settings defined during setup. The agent works through the following steps to engage with customers and drive sales:

1. **Record selection**: The agent selects records that [match the criteria](configure-sales-close-agent-target-customers.md) for high-velocity, low-complexity deals.  
1. **Personalized outreach**: The agent uses templated messaging and customer data to craft personalized outreach communications configured in [the Email content settings](configure-sales-close-agent-email-content.md).  
1. **Initial customer engagement**: The agent sends outreach emails to customers and monitors their responses. Based on customer interactions, the agent recommends [products](configure-sales-close-agent-product-details.md), [addresses objections](configure-sales-close-agent-knowledge-sources.md), and guides customers through the sales process by following up.  
    The agent is designed to process up to 20 emails within a 10-minute timeframe. This limitation helps prevent the agent from consuming excessive AI credits in a short period.  
    When an error occurs, the engagement process is retried up to three times within the next hour, using an exponential backoff strategy. If these attempts fail, the system retries the engagement over the next three days. If the engagement still fails, it's marked as a failure.  
    To resolve the engagement status of a specific record, go to the sales agent record view using the following URL: `<crm_org_url>/main.aspx?pagetype=entitylist&etn=msdyn_salesagentrun`. In the **All Sales Agent Runs** view, filter the **Regarding** column by your record of interest. The **Status** field will display one of three values:  
        - **Active**: Engagement is pending.  
        - **Failure**: Engagement has failed for this record.  
        - **Completed**: Engagement was completed successfully.  
    You can also see email response rates and other engagement metrics in [the insights dashboard](view-sales-close-agent-engage-insights-metrics.md).
    If customers aren't interested, the agent automatically closes the records as lost.  
1. **Follow-up automation**: The agent automates follow-up communications based on predefined triggers like customer responses or changes in deal status. This approach ensures timely and relevant engagement throughout the sales process.  
    - If the customer doesn't respond to the initial email, the agent sends up to four follow-up emails over the next three weeks. The follow-up schedule isn't configurable; however, organizations can request customization by contacting the Microsoft support.
    - If the customer isn't interested or doesn't respond to the follow-up emails, the agent closes the record as lost.  
    - If the customer responds with questions or objections, the agent addresses them using the configured knowledge sources.  
1. **Transaction closure**: The agent helps customers complete their purchases by guiding them to self-service checkout options and closes the records as complete.  

>[!NOTE]
>At any point during the engagement process, if the agent determines that a record requires human intervention (for example, complex objections or specific customer requests), it can escalate the interaction to a human seller for further assistance.  

## View records that are escalated for human intervention

Records that require human intervention are escalated by the agent and can be viewed by supervisors or sellers in Dynamics 365 Sales.  

**Follow these steps**:  

1. In the Sales Hub app, go to **Sales**.  
1. Select the relevant entity. For example, **Opportunities**.  
1. From the view selector, select the ***Entity* from Sales Close Agent - Engage** view.  
    This view displays all records that have been escalated by the Sales Close Agent for human intervention.  

    >[!NOTE]
    >You can only see the records that you have permission to access.

    The following are views available for the supported entities:  

    | Entity | View name |
    |--------|-----------|
    | Account | Accounts from Sales Close Agent - Engage |
    | Contact | Contacts from Sales Close Agent - Engage |
    | Lead | Leads from Sales Close Agent - Engage |
    | Opportunity | Opportunities from Sales Close Agent - Engage |  

1. Open a record to review the details and take necessary actions to assist the customer. The Timeline on the record provides a history of interactions and actions taken by the agent.  

## Related information

[Sales Close Agent overview (preview)](sales-close-agent.md)  
