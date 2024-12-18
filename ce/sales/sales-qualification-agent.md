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

The Sales qualification agent empowers your sales team to qualify leads smartly and efficiently. By leveraging advanced research, prioritization, and engagement capabilities, this agent helps you focus on the most promising leads. Imagine having a personal assistant that prioritizes your leads, shares detailed research insights about each of the leads, drafts a highly engaging and personalized initial outreach email, and reminds you to follow up on your customer asks.

## How the Sales Qualification Agent Works

The agent streamlines the lead qualification process by researching and prioritizing leads, and helping you get started with lead engagement.

### Research

The Sales qualification agent automatically researches leads, providing a 360-degree view of the lead and its account by synthesizing insights from Dataverse and public web sources.

- **Dataverse**: Various insights about the lead from standard Dataverse tables including Lead, Contact, Account, Opportunity.
- **Public web sources**:
  - Company overview with insights on industry, size, products and services, mission statement – LinkedIn, Crunchbase, SEC
  - Company financials with summary of health and key metrics – Yahoo Finance, Crunchbase, SEC, Bloomberg
  - Company news about relevant topics such as product launches, leadership changes, contracts/clients won, community involvement, awards and recognition – LinkedIn, Bloomberg, Business Insider, Reuters

These insights, along with additional criteria configured in the admin experience, help the agent evaluate how well the lead fits with your ideal customer profile. It also ensures that you have a well-rounded understanding of each lead's background, your existing interactions with them, and their current business environment, so that you have the information you need to begin outreach.

### Prioritization

Once the research is complete, the agent prioritizes leads based on the handraiser criteria, other prioritization techniques that you specify, and predictive scores. This step involves analyzing the collected data to assess the potential of each lead. Factors such as company size, industry, location, and product needs are evaluated to rank leads from high to low priority. This systematic approach ensures that your sales efforts are focused on the most promising opportunities.

The prioritized list of leads is displayed in a carousel view at the top of the leads page.

### Engagement

By leveraging the ideal customer profile and research data, the agent generates initial outreach emails tailored to each lead. These emails are designed to capture the interest of the prospect and initiate a meaningful conversation. Additionally, the agent identifies emails that require follow-up and drafts responses based on the information available in Dataverse. Based on the customer's responses, the agent identifies the next best action, whether it be scheduling a meeting, providing additional information, or addressing specific queries.

- **Direct Inquiries**: Leads who reach out directly via phone, email, or chat to inquire about your offerings.

By defining and monitoring these criteria, you can ensure that your sales team focuses on leads who have demonstrated a clear interest in your solutions. The agent prioritizes leads that meet the handraiser criteria over the other leads.

## (Admin) Set Up and Configure the Sales Qualification Agent

As an admin, you can enable and configure the Sales qualification agent in Dynamics 365 Sales to help your sellers qualify leads more effectively. You can specify the details about your company and products you sell, your ideal customer profile, handraiser criteria, and other settings to align the agent with your company's sales strategy and goals.

### Prerequisites

The Sales qualification agent relies on the following components. For sellers to get the complete experience with all outputs, ensure that these components are set up before configuring the agent:

- **Copilot**: Turning on Copilot will allow sellers to see the lead summary and account summary on the research page.
- **Bing search**: In the environment that your agent is activated, Bing search needs to be allowed in PPAC Generative AI feature settings for the web research outputs on the research page to show.

If you're using a custom role, ensure that the role has the necessary permissions to access and use the Sales qualification agent.

### Considerations

Before you set up the Sales qualification agent, review the following considerations:

- When you activate the agent, it installs the sample data to help you understand how the agent works. You can delete the sample data after the product tour.
- The agent is available for free during private preview.
- Review and understand the limitations of the agent for private preview. Learn more about it in the Responsible AI FAQ section.

### How to Set Up and Activate the Agent

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page and select **App Settings**.
2. Go to **General Settings** > **Copilot** > **Agent**.
3. Select **Get started** to set up the agent. The Sales qualification agent settings page opens.

#### General Section

Fill in details about your company, products you sell, and who should have access to the agent:

- **Team access**: Select the security roles that need to use the agent. Typically, you'd assign the agent to sales roles that are responsible for lead qualification and engagement. Sellers can only see the leads that they own in the prioritized list.
- **Company knowledge**: Enter your company's name and website URL. The agent uses this information to tailor its research and generate personalized emails.
- **Product knowledge**: Describe the products or services you sell, in natural language. This information helps the agent understand your offerings and generate lead qualification suggestions and generate outreach emails.

#### Research Section

Define your ideal customer profile (ICP) to help the agent research and prioritize leads that match your target audience.

- **Customer characteristics**: Specify the characteristics that define your ideal customer, such as industry, company size, location, and job titles.
- **Mapped fields in Dataverse**: Map the fields in Dataverse tables to each of the customer characteristics. This mapping helps the agent identify leads that match your ideal customer profile. You can map multiple fields to a characteristic.
- **Other suggested criteria to include**: Select additional criteria that you want the agent to consider when prioritizing leads and map them to the corresponding fields in Dataverse.

#### Prioritization criteria section

Define the handraiser criteria that indicate a lead's interest in your product or service.

- **Identify hand-raisers as priority**: Select the segment to identify handraisers. If you don’t see a relevant segment, create a new one. Leads that meet the handraiser criteria are prioritized over the others. For example, if you want to prioritize leads that have come through your marketing campaign, create a segment for filtering leads by lead source.  

**Prioritization order**: Scroll down to review the prioritization order.

#### Activate the agent

Review all the settings to ensure that they align with your company's sales strategy and goals. You can always come back and update the settings later.

Select **Activate**.

> **Important**: You can't deactivate the agent once it's activated. Contact Microsoft Support for deactivation. Alternatively, you can assign the agent to a role that's not used by any user to effectively deactivate it.

After the agent gets activated, you'll see the **Suggested action** block if any of the settings are incomplete. Select **Open settings** to add the missing details. The agent might take a few minutes to process the last 100 leads, with the newest created leads processed first.

### Grant Permissions to Custom Roles

If you're using a custom role, ensure that the role has the necessary permissions to access and use the Sales qualification agent.

Grant **Organization** level permissions for read, write, create, append, append to, and assign to the following entities:

- Sales Copilot Email Insight
- Sales Copilot Insight
- Sales Copilot Insight Card State

## (Seller) Use the Sales Qualification Agent

As a seller, you know that qualifying leads is crucial to your success. Use the Sales qualification agent to get a prioritized list of leads, detailed research insights about each of them, and personalized outreach emails to engage with potential customers effectively.

### Before You Begin

Before you start using the Sales qualification agent, ensure that the following prerequisites are met:

- Your admin has enabled and configured the Sales qualification agent in Dynamics 365 Sales.
- Your admin has provided the necessary permissions to your security role to access and use the agent.

### Considerations

When you first access the My Open Leads view on the Leads page after the agent activation, you’ll see a consent message. You must provide consent to allow the agent to access external data sources for research and access your emails in Dynamics 365 to check for emails from leads. This consent is only applicable for the carousel view and is not applicable for other Copilot features.

The agent never sends emails automatically. It generates draft emails that you must review, edit if required, and then send.

### Qualify Leads with the Sales Qualification Agent

**From the Focused view**

If your default view is set to Focused view, follow these steps to view the research insights and suggested actions for a lead:

1. In the Sales Hub app, select **Leads**.
1. Select a lead. A banner at the top of the lead form displays the suggested action and the reason for the action. Select the call-to-action button, such as **Draft email**, or **More insights** to view detailed research insights about the lead.

**From the Read Only Grid view**

1. In the Sales Hub app, select **Leads**.
   You'll see a carousel at the top of the **My Open Leads** view. This carousel displays leads that have been researched and prioritized by the Sales qualification agent.
 
   The cards on the carousel display the lead's name, their need, the next best action, the reason for the suggested action, and a call-to-action button.

3. Hover over the up arrow next to the lead’s name to view the reasoning behind the ranking of the lead.

4. Select a lead from the carousel to view the suggested action, detailed research insights, customer profile match, and handraiser status.

5. Review the information and select the suggested action.

### Suggested Actions

This section on the lead insights page displays the next best action for the lead based on the research data, your company and product information, and emails from the lead.

The following actions are suggested:
- Initial outreach: If the lead has not been contacted yet, the agent suggests drafting an initial email to engage with the lead.
- **Draft initial email**: Let Copilot craft a compelling introductory email to engage with the lead. The agent generates a highly personalized email to the lead, based on the lead research data, your company and product information (defined by your admin during setup), and lead and account information from Dataverse.
  - This action is displayed only when the following conditions are met:
    - No prior emails, no upcoming meetings, no past appointments, and no previously unanswered calls.
    - The following fields in the lead record have valid values:
      - Company name which can be associated with an account.
      - Email address which is active and deliverable.
      - Lead's first and last name.
- **Follow up actions**: 
  After the initial email to the lead, the agent reminds to you to stay engaged with the lead by suggesting follow-up actions. These actions are based on the lead's response to your initial email or any other interactions with the lead.
  
- **Schedule appointment**: If the lead has shown interest in meeting with you, schedule a meeting to discuss further.
- **Create task**: If the lead has requested a follow-up or you need to perform a specific action, create a task to track the progress. For example, if a lead has requested a discount, you can create a task to discuss with your manager.
- **Send follow-up email**: If the lead has asked for more information, send an email with the required details. Copilot generates a draft email with the necessary information based on the lead's request.

> **Note**: When you select Send email for email-based actions, the email is sent directly if server-side synchronization is configured for your organization. If not, the email opens in Outlook for you to review and send.

### Research Insights

On the insights page, you can get a 360-degree view of the lead:

- **Email validation**: The Sales Qualification Agent performs two checks on a lead's primary email address (lead.emailaddress1).
  - **Email validity**: First, it checks that the email is properly formatted and deliverable by looking for the same issues as the current email validation service in Sales.
  - **Email type**: Next, it identifies whether the email is a work or personal address.
  - These checks help ensure that lead emails are active, deliverable, and relevant for business communications.
- **Suggested action and supporting reasons**: At the top of the research page, you will see a box with a suggested action along with supporting reasons for the suggested action based on research insights and ideal customer profile criteria defined by your admin in the settings.
- **About lead**: This section includes information about the lead, including:
  - Lead summary: Summarizes key fields on the lead and its related entities that have been configured by your admin.
  - Who knows whom: Co-workers who have previously interacted with the lead (emails, meetings).
  - Open opportunities related to the lead
  - You will also get suggested contacts to connect to the lead based on email. Otherwise, you can manually connect a contact record to the lead using the “connect a contact record” CTA to enrich the insights.
- **About account**: This section includes information about the lead’s company, including:
  - Account summary: Summarizes key fields on the account and its related entities that have been configured by your admin.
  - Company overview: Insights pulled from the web on the company’s industry, size, products and services, and mission statement.
  - Company finances: Insights pulled from the web on the company’s financial health and key financial metrics.
  - Company news: Insights pulled from the web on relevant news topics such as product launches, leadership changes, contracts/clients won, community involvement, awards and recognition.
  - Suggested contacts: Other contacts at the account that the seller can reach out to.
  - Open opportunities related to the account
  - These insights will only show up if there is an account record connected to the lead. You can connect an account using the “connect an account” record CTA.