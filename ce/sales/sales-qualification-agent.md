---
title: Sales qualification agent
description:  
ms.date: 11/18/2024
ms.topic: how-to
ms.service: dynamics-365-sales
content_well_notification:
 - AI-contribution
ms.custom:
 - ai-gen-docs-bap
 - ai-gen-desc
 - ai-seo-date:10/04/2023
 - bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Sales qualification agent

The Sales qualification agent helps you qualify leads effortlessly by researching, prioritizing, and helping you engage with potential customers. It prioritizes leads based on the prioritization criteria that you define, enabling you to focus on high-potential opportunities. The agent also generates personalized outreach emails to help you engage with leads effectively. By leveraging the Sales qualification agent, you can qualify leads more efficiently and quickly and increase your sales productivity.

## How the Sales qualification agent works

The agent streamlines the lead qualification process by researching, prioritizing, and helping with lead engagement.

### Research

The Sales qualification agent conducts thorough lead research by drawing data from CRM and a variety of sources across the internet. By aggregating data from social media, industry reports, news articles, and other relevant platforms, the agent compiles a comprehensive profile of potential leads. This ensures that you have a 360 degree view of your lead's background, interests, and current business environment.

- **CRM Data**: The agent pulls data from CRM records, such as lead details, interactions, and activities.
- **News articles**: The agent scans news articles related to the lead's company and their budget, authority, need, and timeline (BANT) criteria. The following sources are used for need and budget:
  - Need - ZDNet, CIO.com, and Bing. 
  - Revenue/Budget - Company’s SEC 10K filings (if public company), Yahoo Finance, Google Finance, PRNewsWire, BusinessWire, TechCrunch and ZDNet.


### Prioritization

Once the research is completed, the agent prioritizes leads based on the criteria that you define such as, ideal customer profile, hand-raiser criteria, highly engaged leads, newly created leads, and so on. The agent also uses predictive scores to rank the leads. This step involves analyzing the collected data to assess the potential of each lead. Factors such as company size, industry, location, and product needs are evaluated to rank leads from high to low priority. This systematic approach ensures that your sales efforts are focused on the most promising opportunities.

### Engagement

By leveraging the ideal customer profile and research data, the agent generates initial outreach emails tailored to each lead. These emails are designed to capture the interest of the prospect and initiate a meaningful conversation. Additionally, the agent assists with follow-ups and nudges, ensuring that no potential lead falls through the cracks. Based on the customer's responses, the agent identifies the next best action, whether it be scheduling a meeting, providing additional information, or addressing specific queries. 

## Ideal Customer Profile

An ideal customer profile (ICP) is a detailed description of a target customer who would benefit the most from your company's products or services. Your ideal customer profile (ICP) might include characteristics like product type, industry, company size, and location. For instance, if your company sells advanced CRM software, your ICP might include:

- **Industry**: Technology, Financial Services, Healthcare
- **Company Size**: Mid to large-sized enterprises with 500+ employees
- **Geographic Location**: North America, Europe
- **Pain Points**: Need for improved customer relationship management, desire to streamline sales processes, requirement for robust data analytics
- **Decision Makers**: Chief Information Officer (CIO), Chief Technology Officer (CTO), Head of Sales

By focusing on leads that match this profile, you can tailor your approach to address specific needs and challenges, thereby increasing the likelihood of a successful sale.

## Handraiser Criteria

Handraiser criteria allow you to define specific conditions that qualify a lead as a "handraiser." Handraisers are leads who have shown explicit interest in your product or service, indicating a higher likelihood of conversion. By establishing clear handraiser criteria, you can quickly identify and prioritize these high-potential leads. Common handraiser criteria include:

- **Form Submissions**: Leads who fill out contact forms, request demos, or download gated content.
- **Email Engagement**: Leads who frequently open emails, click on links, or respond to outreach.
- **Website Behavior**: Leads who visit key pages on your website, such as pricing, product details, or case studies.
- **Event Participation**: Leads who attend webinars, trade shows, or other company-hosted events.
- **Direct Inquiries**: Leads who reach out directly via phone, email, or chat to inquire about your offerings.

By defining and monitoring these criteria, you can ensure that your sales team focuses on leads who have demonstrated a clear interest in your solutions, thereby improving the efficiency and effectiveness of your sales process.

## License requirements

The Sales qualification agent is available with Dynamics 365 Sales Premium and Sales Enterprise licenses. 

## Set up and configure the Sales qualification agent

As an admin, you can enable and configure the Sales qualification agent in Dynamics 365 Sales to help your sellers qualify leads more effectively. You can specify the details about your company and products you sell, your [ideal customer profile](#ideal-customer-profile), [handraiser criteria](#handraiser-criteria), and other settings to align the agent with your company's sales strategy and goals. 

### Prerequisites

The Sales qualification agent relies on the following components. So, ensure that these components are set up before configuring the agent:

- Copilot (used for research summarization)

- Predictive scoring (used for lead ranking)
- Who knows whom (used in lead research)
- Email validation (used in lead research)
- If you're using a custom role, ensure that the role has the [necessary permissions](#grant-permissions-to-custom-roles) to access and use the Sales qualification agent.

### Considerations

Before you set up the Sales qualification agent, review the following considerations:

- When you activate the agent, it installs the sample data to help you understand how the agent works. You can delete the sample data after the product tour. 
   Q: In another JTBD, I saw that the product tour should be on a real lead. Please clarify which one we're going with.
- The agent is available for free during private preview. 
   Q: Do we need to cover the cost aspect for public preview?

To set up the Sales qualification agent, follow these steps:

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page and select **App Settings**.

1. Go to **General Settings** > **Copilot** > **Agent**.
1. Select **Get started** to set up the agent. 
   The page displays the **Sales qualification agent** settings.
   :::image type="content" source="media/sqa-admin-settings.png" alt-text="Screenshot of the Sales qualification agent setting page.":::
1. In the **General** section, fill in details about your company, products you sell, and who should have access to the agent:
    1. Under **Team access**, select the security roles that need to use the agent. Typically, you'd assign the agent to sales roles that are responsible for lead qualification and engagement. Users can see only the leads that they own.

       Q: Can they give access to all security roles or specify users?
    1. Under **Company knowledge**, enter your company's name and website URL. The agent uses this information to tailor its research and generate personalized emails. Q: How is the company info used in research? Why is there a Next button here? What happens when you click it?
    1. Under **Product knowledge**, describe the products or services you sell in natural language. This information helps the agent understand your offerings and generate lead qualification suggestions and generate outreach emails. 
       Example product description: "We offer a cloud-based CRM solution that helps businesses streamline sales processes, improve customer relationships, and drive revenue growth. Our platform includes features such as lead management, opportunity tracking, email integration, and analytics."
       Q: How is the product info used in research? Why is there a Next button here? What happens when you click it?
1. In the **Research** section, define your ideal customer profile (ICP) to help the agent prioritize leads that match your target audience. 
    1. Under **Customer characteristics**, specify the characteristics that define your ideal customer, such as industry, company size, location, and job titles. 

    1. Under **Mapped fields in Dataverse**, map the fields in Dataverse tables to each of the customer characteristics. This mapping helps the agent identify leads that match your ICP. You can map multiple fields to a characteristic. For example, if you specify the "Industry" as a customer characteristic, you can map it to the `Industry` field in the `Lead` table and the `Industry` field in the `Account` table in Dataverse.
    1. Under **Other suggested criteria to include**, select additional criteria that you want the agent to consider when prioritizing leads and map them to the corresponding fields in Dataverse.
1. Under **Prioritization criteria**, define the handraiser criteria that indicate a lead's interest in your product or service. 
    1. Under **Identify hand-raisers as priority**, select the segment to identify handraisers. For example, if you select Engaged Leads as the segment, the agent prioritizes leads who have shown high engagement with your content or outreach. Leads are prioritized based on the following ranking: handraisers, highly engaged leads, leads from existing customers, and recently created leads.

    Q: What about ICP? How does it affect prioritization? Where are the hand-raiser segments defined? How's the Engaged leads segment different from Highly engaged leads in the default ranking?
1. Review all the settings to ensure that they align with your company's sales strategy and goals. You can always come back and update the settings later.
   :::image type="content" source="media/sqa-admin-settings-review.png" alt-text="Screenshot of the completed Sales qualification agent settings page.":::
1. Select **Activate**.
   > [!IMPORTANT]
   > You can't deactivate the agent once it's activated. Contact Microsoft Support for deactivation. You can also assign the agent to a role that's not used by any user to effectively deactivate it.

   After the agent gets activated, you'll see the **Suggested action** block if any settings are incomplete. Select **Open settings** to add the missing details.

  Q: There's no Save button here. Why? What if I want to activate later?
  Q: Does the agent try to research and prioritize leads at the time of activation or later at a specific time? Which leads are included in the initial research and prioritization? For newly created leads, when does the agent start researching and prioritizing them? Does the research data show the source?

### Grant permissions to custom roles

If you're using a custom role, ensure that the role has the necessary permissions to access and use the Sales qualification agent. 

Grant **Organization** level permissions to read, write, create, append, append to, and assign to the following entities:

- Sales Copilot Email Insight
- Sales Copilot Insight
- Sales Copilot Insight Card State

:::image type="content" source="media/sqa-custom-role-permissions.png" alt-text="Screenshot of the Permissions page in Power Platform admin center.":::

## Use the Sales qualification agent

As a seller, you know that qualifying leads is crucial to your success. The Sales qualification agent empowers you to qualify leads smartly and efficiently. By leveraging advanced research, prioritization, and engagement capabilities, this agent helps you focus on the most promising leads. Imagine having detailed insights at your fingertips, allowing you to tailor your approach and engage with leads in a personalized manner. With the Sales qualification agent, you can do just that.

### Before you begin

Before you start using the Sales qualification agent, ensure that the following prerequisites are met:

- Your admin has [enabled and configured the Sales qualification agent](#set-up-and-configure-the-sales-qualification-agent) in Dynamics 365 Sales.

- Your admin has provided the necessary permissions for you to use the agent.

### Qualify leads with the Sales qualification agent

1. In the Sales Hub app, select **Leads**.
   You'll see a carousal at the top of the lead view. This carousal displays leads that have been researched and prioritized by the Sales qualification agent. 

    > [!NOTE]
    > When you first access the **Leads** page after the agent has been enabled, the carousal displays a consent message. You must provide consent to allow the agent to access external data sources for research and access your emails in Dynamics 365 to check for emails from leads. This consent is only applicable for the carousal view and is not applicable for other Copilot features.

2. Select a lead from the carousal to view the recommended action, detailed research insights, customer profile match, and handraiser status.
1. When you're ready to engage with the lead, select **Send Email** to craft a personalized message based on the research data and ICP.

## How the research data is generated

The agent generates research data by aggregating information from various sources to provide a comprehensive view of each lead. 
The agent uses the following sources to generate research data:

- **CRM Data**: The agent pulls data from CRM records, such as lead details, interactions, and activities.
- **News articles**: The agent scans news articles related to the lead's company and their budget, authority, need, and timeline (BANT) criteria. The following sources are used for need and budget:
  - Need - ZDNet, CIO.com, and Bing. 
  - Revenue/Budget - Company’s SEC 10K filings (if public company), Yahoo Finance, Google Finance, PRNewsWire, BusinessWire, TechCrunch and ZDNet.