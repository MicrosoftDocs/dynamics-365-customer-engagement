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

# Sales Qualification Agent

The Sales qualification agent helps you make informed decisions using research data on leads and ideal customer profiles. It enables you to identify high-potential leads, understand your audience, and refine your sales strategies.

An ideal customer profile (ICP) is a detailed description of a target customer who would benefit the most from your company's products or services. Your ideal customer profile (ICP) might include characteristics like product type, industry, company size, and location. For instance, if you sell enterprise software, you might target mid to large-sized tech firms in urban areas, with revenues over $50 million and a need for scalable IT solutions.

The agent streamlines the lead qualification process by researching, prioritizing, and helping with lead engagement. 

**Research**

The Sales qualification agent conducts a thorough lead research by drawing data from CRM and a variety of sources across the internet. By aggregating data from social media, industry reports, news articles, and other relevant platforms, the agent compiles a comprehensive profile of potential leads. This ensures that you have a well-rounded understanding of each prospect's background, interests, and current business environment.


**Prioritization**

Once the research is complete, the agent prioritizes leads based on your Ideal Customer Profile (ICP) and predictive scoring models. This step involves analyzing the collected data to assess the potential of each lead. Factors such as company size, industry, location, and product needs are evaluated to rank leads from high to low priority. This systematic approach ensures that your sales efforts are focused on the most promising opportunities.

**Engagement**

By leveraging the ICP and research data, the agent generates initial outreach emails tailored to each lead. These emails are designed to capture the interest of the prospect and initiate a meaningful conversation. Additionally, the agent assists with follow-ups and nudges, ensuring that no potential lead falls through the cracks. Based on the customer's responses, the agent identifies the next best action, whether it be scheduling a meeting, providing additional information, or addressing specific queries. 

## Ideal Customer Profile

An ideal customer profile (ICP) is a detailed description of a target customer who would benefit the most from your company's products or services. For instance, if your company sells advanced CRM software, your ICP might include:

- **Industry**: Technology, Financial Services, Healthcare
- **Company Size**: Mid to large-sized enterprises with 500+ employees
- **Geographic Location**: North America, Europe
- **Pain Points**: Need for improved customer relationship management, desire to streamline sales processes, requirement for robust data analytics
- **Decision Makers**: Chief Information Officer (CIO), Chief Technology Officer (CTO), Head of Sales

By focusing on leads that match this profile, you can tailor your approach to address specific needs and challenges, thereby increasing the likelihood of a successful sale. 

### Handraiser Criteria

Handraiser criteria allow you to define specific conditions that qualify a lead as a "handraiser." Handraisers are leads who have shown explicit interest in your product or service, indicating a higher likelihood of conversion. By establishing clear handraiser criteria, you can quickly identify and prioritize these high-potential leads. Common handraiser criteria include:

- **Form Submissions**: Leads who fill out contact forms, request demos, or download gated content.
- **Email Engagement**: Leads who frequently open emails, click on links, or respond to outreach.
- **Website Behavior**: Leads who visit key pages on your website, such as pricing, product details, or case studies.
- **Event Participation**: Leads who attend webinars, trade shows, or other company-hosted events.
- **Direct Inquiries**: Leads who reach out directly via phone, email, or chat to inquire about your offerings.

By defining and monitoring these criteria, you can ensure that your sales team focuses on leads who have demonstrated a clear interest in your solutions, thereby improving the efficiency and effectiveness of your sales process.

## Licensing requirements

The Sales Qualification Agent with available with Dynamics 365 Sales Premium and Sales Enterprise licenses. 

## Set up and configure the Sales Qualification Agent

As an admin, you can enable and configure the Sales Qualification Agent in Dynamics 365 Sales to help your sellers qualify leads more effectively. You can customize the Ideal Customer Profile (ICP), handraiser criteria, and other settings to align the agent with your company's sales strategy and goals. 

**Prerequisites:**

The Sales qualification agent relies on the following components. So, ensure that these components are set up before configuring the agent:

- Copilot (used for research summarization)

- Predictive scoring (used for lead ranking)
- Who knows whom (used in lead research)
- If you're using a custom role, ensure that the role has the necessary permissions to access and use the Sales Qualification Agent.

To set up the Sales Qualification Agent, follow these steps:

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page and select **App Settings**.

1. Under **General Settings**, select **Copilot**.

## Use the Sales Qualification Agent

As a seller, you know that qualifying leads is crucial to your success. The Sales Qualification Agent empowers you to qualify leads smartly and efficiently. By leveraging advanced research, prioritization, and engagement capabilities, this agent helps you focus on the most promising leads. Imagine having detailed insights at your fingertips, allowing you to tailor your approach and engage with leads in a personalized manner. With the Sales Qualification Agent, you can do just that.

### Before you begin

Before you start using the Sales Qualification Agent, ensure that the following prerequisites are met:

- Your admin has enabled and configured the Sales Qualification Agent in Dynamics 365 Sales.
- You have the necessary permissions to access and use the agent.

### Qualify leads with the Sales Qualification Agent

1. In the Sales Hub app, select **Leads**.
   You'll see a carousal at the top of the lead view. This carousal displays leads that have been researched and prioritized by the Sales Qualification Agent. 

    > [!NOTE]
    > When you first access the **Leads** page after the agent has been enabled, the carousal displays a consent message. You must provide consent to allow the agent to access external data sources for research and access your email to check for emails from leads. This consent is only applicable for the carousal view and is not applicable for other Copilot features.

2. Select a lead from the carousal to view the recommended action, detailed research insights, customer profile match, and handraiser status.
1. When you're ready to engage with the lead, select **Send Email** to craft a personalized message based on the research data and ICP.

## How the research data is generated

The agent uses the following sources to generate research data:

- **CRM Data**: The agent pulls data from CRM records, such as lead details, interactions, and activities.
- 