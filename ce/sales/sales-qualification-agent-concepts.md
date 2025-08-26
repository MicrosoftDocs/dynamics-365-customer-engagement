---
title: Understand the Sales Qualification Agent concepts (preview)
description: Learn about the concepts of the Sales Qualification Agent in Dynamics 365 Sales, including ideal customer profile, purchase interest, and BANT.
ms.topic: conceptual 
ms.date: 07/31/2025
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom: bap-template
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Understand the Sales Qualification Agent concepts (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The concepts described in this article are applicable for the Sales Qualification Agent in Dynamics 365 Sales and applicable for both Research-only mode and Research and engage modes. The concepts help you understand how the agent evaluates leads and determines their fit for your organization. Further, the agent uses these concepts to provide insights and recommendations for lead qualification.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## What is the ideal customer profile and how is the fit determined?

The *ideal customer profile* (ICP) is a detailed description of a customer who would benefit the most from your company's products or services. Your ideal customer profile might include characteristics like industry, company size, job title of the lead, location, and annual revenue.

The ICP fit is determined based on the attributes defined in [the Ideal customer profile section of the agent configuration](configure-sales-qualification-agent-handoff-criteria.md#configure-the-ideal-customer-profile-and-bant-criteria). The agent categorizes leads into three categories based on the ICP attributes:

- **High fit**: The lead matches more than 70% of the ICP attributes. This indicates that the lead is a strong candidate for your products or services.
- **Moderate fit**: The lead matches 50% to 70% of the ICP attributes. This indicates that the lead may be a potential candidate for your products or services, and can be pursued after the high fit leads.
- **Low fit**: The lead matches less than 50% of the ICP attributes. This indicates that the lead is not a good candidate to pursue.

For instance, if your company sells software solutions for retail businesses, your ICP might include companies in the retail industry with a certain number of employees and annual revenue. The following table provides examples of ICP attributes for retail businesses:

| Criteria | Details |
|----------|---------|
| Industries targeted | Retail companies, including department stores, specialty retailers, e-commerce platforms, quick commerce, and grocery chains |
| Size of the customer | 1000 to 50000+ employees |
| Job Title of the lead | Procurement decision makers in retail industry or C-Suite executives |
| Annual revenue range | $100 million to $10 billion+ |
| Location of target customers | Urban and suburban areas in North America with high consumer traffic, except New York |

The following table provides a few sample leads and their ICP fit category based on the above attributes:

| Account Name | Industry | Company Size | Job Title | Annual Revenue | Location | ICP Fit | Reasoning |
|--------------|----------|--------------|-----------|----------------|----------|---------|-----------|
| Contoso Ltd. | Retail | 10,000 employees | Procurement Manager | $500 million | New York, NY | High fit | Matches all ICP criteria, except location as New York is excluded. |
| Fabrikam Inc. | E-commerce | 500 employees | CFO | $1 billion | San Francisco, CA | High fit | Matches all ICP criteria except company size |
| Northwind Traders | Specialty Retail | 200 employees | CEO | $80 million | Chicago, IL | Moderate fit | Matches industry, job title, and location criteria, but company size and revenue don't match. |
| Tailspin Toys | Department Store | 1000 employees | Procurement Director | $95 million | Santiago, Chile | Moderate fit | Matches industry, company size, and job title criteria, but revenue and location don't match. |
| Wingtip Toys | Manufacturing | 500 employees | Operations Manager | $150 million | Hyderabad, India | Low fit | Except for revenue, none of the ICP criteria match. |
| Blue Yonder Airlines | Aviation | 500 employees | Software engineering manager | $500 million | Suburban area, CA | Low fit | Does not match any of the ICP criteria. |

## What is purchase interest and how is it determined?

Purchase interest identifies a lead’s readiness to buy your product or services, is determined based on the emails that are sent and received. The agent sends emails with open-ended questions to gauge the lead's interest and analyzes responses based on the value proposition of your product or service, received emails, and follow-up. The agent runs a model to analyze content and data patterns for signals in all emails from your leads as soon as they're received.  
After analysis, the model identifies purchase interest as either positive or negative based on the confidence level. Along with this, the model also records the reason which helps in preparing the handover summary for the seller.  

### Positive purchasing interest

Positive purchasing interest refers to the level of interest a potential customer shows in purchasing your product or service and classified into high, medium, and low intent.  

- **High intent**: Indicates a strong interest in purchasing. For example, if a lead asks, I'm interested in the pricing details for your enterprise plan. Please share the details. We’re finalizing our budget this week. This shows a specific pricing inquiry along with urgency to decide.
- **Medium intent**: Indicates a moderate purchase interest. For example, if a lead says, we’re exploring different pricing options. Could you clarify the differences between your plans? This shows interest but not urgency, indicating they are still in the research phase.
- **Low intent**: Indicates a low interest. For example, if a lead says, do you have a general pricing page I can check? This shows no strong intent and casual browsing.

### Negative purchasing interest

Negative purchasing interest refers to the level of disinterest a potential customer shows in purchasing your product or service and classified into high and medium intent.

- **High intent**: Indicates a strong disinterest in purchasing. For example, if a lead says, we don’t have the budget for this, and it’s not a priority for us. This shows a clear lack of interest and budget constraints.
- **Medium intent**: Indicates a moderate disinterest. For example, if a lead says, I just want to understand your pricing but have no immediate plans to buy. This shows curiosity but no immediate intent to purchase.

### Signal categories with examples

The following signal types are analyzed to determine the purchase interest based on the confidence levels:

- **Interest in pricing, plans, and availability**: Inquiries made by leads about the cost, different pricing tiers, volume discounts, or the availability of the product or service. This type of interest is a strong indicator that the lead is evaluating the affordability and scalability of the product before making a purchase decision.

    | Confidence level | Positive purchase interest examples | Reason | Negative purchase interest examples |
    |------------------|-------------------------------------|--------|-------------------------------------|
    | High | Can you send me the pricing details for your enterprise plan? | Specific pricing inquiry with urgency | We don’t have the budget for this, and it’s not a priority for us. |
    | Medium | We’re exploring different pricing options. Could you clarify the differences between your plans? | Interest but not urgency | I just want to understand your pricing but have no immediate plans to buy. |
    | Low | Do you have a general pricing page I can check? | No strong intent, casual browsing | &mdash; |

- **Budget and approval decisions**: Inquiries made by leads about budget approvals or the need for final pricing details for internal approvals. This type of interest is a strong indicator that the lead is evaluating financial feasibility and seeking internal approval before making a purchase decision.

    | Confidence level | Positive purchase interest examples | Reason | Negative purchase interest examples |
    |------------------|-------------------------------------|--------|-------------------------------------|
    | High | We have a budget approved for this quarter and need to finalize a vendor. What are the next steps. | Confirmed budget and they are at a decision-making stage. | Our finance team won’t approve this. So, we won’t be moving forward. |
    | Medium | I think we may have a budget for this, but I need to check with my finance team. Can you share a quote. | Considering but not confirmed, dependent on internal approval. | Budget discussions will happen next quarter; we’re not sure yet. |
    | Low | I’m not sure if we have the budget for this. Just exploring options. | No commitment, uncertainty about purchasing ability. | &mdash; |

- **Questions about product features or use cases**: Inquiries made by leads seeking clarification on specific features or how the product fits their needs. This type of interest is a strong indicator that the lead is evaluating the product or service's capabilities and suitability for their specific requirements.  

    | Confidence level | Positive purchase interest examples | Reason | Negative purchase interest examples |
    |------------------|-------------------------------------|--------|-------------------------------------|
    | High | Does your solution integrate with Contoso? We need this feature for our sales automation. | Specific feature tied to their workflow, showing serious evaluation. | We’re not interested in this type of solution at all. |
    | Medium | Can you explain how your tool helps with workflow automation. | Shows curiosity but not linked to an immediate need. | I’m just researching different tools but not looking to buy. |
    | Low | I’m not sure if we have the budget for this. Just exploring options. | No commitment, uncertainty about purchasing ability. | &mdash; |

- **Comparisons with competitors**: Inquiries made by leads asking how your product or service compares to competitors in terms of pricing, features, or performance. This type of interest is a strong indicator that the lead is actively evaluating options and needs convincing factors to finalize their decision.

    | Confidence level | Positive purchase interest examples | Reason | Negative purchase interest examples |
    |------------------|-------------------------------------|--------|-------------------------------------|
    | High | We’re deciding between your product and Contoso. Can you provide a comparison on pricing, features, and support. | Actively evaluating competitors, close to decision. | We are locked in a 3-year contract with Contoso and won’t switch. |
    | Medium | How does your tool compare to others in the market? | General comparison but no mention of a competitor or urgency. | We’re happy with Contoso but just exploring alternatives. |
    | Low | What makes your product different? | Very broad, doesn’t indicate serious evaluation. | &mdash; |

- **Request for a demo or trial**: Inquiries made by leads expressing interest in evaluating the product or service firsthand before making a purchase decision. This type of interest is a strong indicator that the is lead seriously considering the product and wants to experience its features and capabilities.

    | Confidence level | Positive purchase interest examples | Reason | Negative purchase interest examples |
    |------------------|-------------------------------------|--------|-------------------------------------|
    | High | Can we schedule a demo next week? We want to see how it works in our environment. | Specific request for a demo, indicating serious evaluation. | We’re not interested in a demo at this time. |
    | Medium | I would like to see a demo at some point. What’s your availability? | Interest in trying the product but not urgent. | Can we get a trial? No commitments right now. |
    | Low | Do you offer any demos? | Casual inquiry, no strong intent to evaluate. | &mdash; |

- **Urgency or implementation timeline mentioned**: Refers to emails that indicate a deadline for decision-making or ask about onboarding speed. This type of interest is a strong indicator that the lead has a pressing need and is ready to act quickly.

    | Confidence level | Positive purchase interest examples | Reason | Negative purchase interest examples |
    |------------------|-------------------------------------|--------|-------------------------------------|
    | High | We need a new solution onboard within the next 30 days. How quickly can we implement this? | Urgency + intent to evaluate quickly. | This is not a priority for us in the foreseeable future. |
    | Medium | We’re thinking about adopting a solution later this year. What’s your typical onboarding process? | Some intent but not urgent. | Maybe next year, but nothing is confirmed. |
    | Low | We’re just researching for now and might look into this in the future? | No clear purchase timeline. | &mdash; |

- **Interest in customer success stories or use cases**: Inquiries made by leads requesting case studies or proof of ROI (Return on Investment) to justify their purchase. This type of interest is a strong indicator that the lead is seeking validation and real-world proof before finalizing their choice.

    | Confidence level | Positive purchase interest examples | Reason | Negative purchase interest examples |
    |------------------|-------------------------------------|--------|-------------------------------------|
    | High | Do you have case studies of companies in our industry using your solution? We need to justify this purchase internally. | Serious evaluation, needs validation for approval. | We’re not evaluating solutions, just gathering insights. |
    | Medium | I’d love to see how others use your tool. Can you share some examples? | Interested but not necessarily tied to a decision. | It would be great to see case studies but there are no plans to implement yet. |
    | Low | Do you have any customer testimonials? | General curiosity, not tied to a buying decision. | &mdash; |

## What is BANT and how is the fit calculated?

The BANT criteria is a qualification methodology that helps determine whether a lead is ready for handover to the seller. BANT is known as Budget, Authority, Need, and Timeline. Here's a breakdown of each component:  

- **Budget**: Evaluates if the prospect has the financial resources to afford the product or service. For example, if the lead's budget is between $10M - $20M, it meets the criteria.  
- **Authority**: Identifies if the prospect is the decision-maker or has the influence to make the purchase decision. For instance, if the lead is a decision-maker, it meets the criteria.  
- **Need**: Assesses if the prospect has a genuine need for the product or service. For example, if a sales team is struggling with lead tracking and needs a better CRM system, it meets the criteria.  
- **Timeline**: Determines if the prospect has a specific timeframe for making the purchase decision. For example, if the lead needs to close within the next three months, it meets the criteria.  

The BANT criteria can be detected from various sources such as emails, CRM configuration, and research. The agent continuously analyzes incoming emails for interest and once identified, the lead is ready to be transferred to the seller. The BANT model provides input on BANT fit of a lead, which helps in determining the qualification.

## How does the agent determine the lead rating?

The agent determines the lead rating based on the Fit, Intent, Recency, Engagement (FIRE) framework:

- **Fit**: Measures how well the lead aligns with the Ideal Customer Profile (ICP) criteria, such as industry, company size, location, and role.
- **Intent**: Assesses the lead’s level of interest based on signals like purchase inquiries, pricing requests, demo requests, or stated business challenges.
- **Recency**: Evaluates the freshness of the interactions or engagements as on the date of research. The recency is categorized as follows:
    - Interactions within 7 days are considered recent.
    - Interactions between 8 and 21 days are considered moderate.
    - Interactions older than 21 days are considered old.
- **Engagement**: Assesses the frequency, quality, and depth of interactions, including opened emails, replies, booked meetings, and downloads.

The agent evaluates leads based on signals from the following sources:

- Customer Insights - Journeys interaction data such as email opens, clicks, and replies.
- Timeline activity data such as emails, appointments, and phone calls in the past 60 days.
- Company research data such as company size, industry, and location.
- In Research and engage mode, the agent also considers the lead's engagement with the emails sent by the agent.

## Related information

- [Sales Qualification Agent overview](sales-qualification-agent.md)  
- [Configure Sales Qualification Agent](configure-sales-qualification-agent.md)