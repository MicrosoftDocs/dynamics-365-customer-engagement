---
title: Use the canvas experience for accounts (preview)
description: Use the account canvas in Dynamics 365 Customer Service to review account details, insights, activities, relationships, and related business records.
ms.date: 11/17/2026
ms.topic: how-to
ms.service: dynamics-365-customer-service
author: gandhamm
ms.author: mgandham
ai-usage: ai-generated
---

# Use the canvas experience for accounts (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Use the account canvas to review account details, insights, activity history, contacts, and related business records. Update supported information without switching between forms.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Prerequisites

- Your administrator enables the account canvas. To learn more, see [Manage canvases in CRM Canvas Designer](manage-canvases.md).
- You have the required license and access to the account and its related records. For supported licenses, see the [Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/?LinkId=866544).

## Open the account canvas

1. In your app, go to **Accounts**.
2. Open the account you want to review. The account opens in the canvas experience.

## Understand the account canvas


| Area | What you see | What you can do |
| --- | --- | --- |
| Command bar | **Open classic view** and other record commands available in your app. | <ul><li>Select **Open classic view** for fields, commands, or customizations that the canvas doesn't support.</li><li>Select **Open canvas view** on the classic form to return.</li></ul> |
| Account header | Account name and identifying details, including primary contact, contact count, opportunities, and annual revenue. | <ul><li>Confirm you opened the right account.</li><li>Select the linked primary contact to open the contact canvas.</li></ul> |
| **What's important now?** | Insight cards about engagement, opportunities, and service risks. By default, the component shows up to three cards. To view insights, your administrator must [set up and configure insights](set-up-configure-insights.md). | <ul><li>Select **See more** for additional cards or **See less** for the initial set.</li><li>Select a card's information button to learn what the insight measures.</li><li>Check the **As of** timestamp to see when the calculation ran.</li><li>Review related records and recent activities before acting on a result.</li><li>If a card offers an email action, review the recipient and supporting facts, and edit the draft before sending it. The action doesn't send the message automatically, create a related record, or book a meeting.</li></ul> |
| Organizational context | Two sections: **Account information** and **Consent**. Your permissions and the field type determine what you can change. | <ul><li>Select **Edit** in the section you want to update, change supported fields, and select **Save**.</li></ul> |
| **What's happened before?** | **Timeline** of recorded activities and notes. Conversations that weren't recorded don't appear. Available activity commands depend on the activity type, state, and your permissions. | <ul><li>Select **Log activity**, choose an activity type, and enter the details to create a new activity.</li><li>Select **Emails**, **Appointments**, **Notes**, or **Other** to filter by activity type, or **All** to show all types.</li><li>Select **Sort** to change the activity order, or use search and the available filters to find an activity.</li><li>Use an activity's available commands to open its record, edit it, or delete it.</li><li>Select **Expand** for more space to review the history.</li></ul> |
| Relationships: **Contact information** | A read-only view of the primary contact's email, phone, role, and available communication preferences. | <ul><li>Select the linked contact name to open the contact canvas.</li></ul> |
| Relationships: **Relationship map** | Recorded reporting relationships and connection paths. The map can't identify an introduction path to someone with no recorded connection. | <ul><li>Select **Org chart** to review reporting relationships. Use search and filters to locate a person, or select **Expand** for a larger view.</li><li>Select **Add stakeholder** in **Org chart** to add a person.</li><li>Use a stakeholder's available role actions to mark the person as a decision maker or influencer.</li><li>Select **Who knows whom** to review connection paths. This view doesn't offer **Add stakeholder** or **Expand**.</li></ul> |
| Business involvement | Related records by category, such as opportunities, leads, and cases. Search, filtering, and sorting apply only to loaded records. | <ul><li>Select a category, search for a record, and filter by current state.</li><li>You can add the required record.</li><li>Sort results and use page controls where available.</li><li>Clear search and filters to review all loaded results in the category.</li><li>Use the classic form for unavailable record actions; related-record lists don't support inline editing.</li></ul> |

## Understand insights and recommendations

Use account insights to assess engagement, opportunity progress, and service activity across an organization. Available insights depend on your administrator's configuration and the data you can access. Cards can show a value, comparison, trend, or list of records.

| Insight | Description |
| --- | --- |
| Account Engagement Recency | Shows how long it's been since anyone at the account responded or otherwise engaged. A risk signal appears when the gap exceeds 14 days. |
| Account Momentum | Shows whether deal progress and engagement risk indicate increasing or decreasing momentum. It indicates direction, not overall account health. |
| Competitor Risk | Identifies competitors associated with open opportunities and the deals they affect. |
| Deal Risk Signals | Identifies risk factors in open deals, including information about champions and competitors. |
| Deal Stage Distribution | Shows the number of open deals in each sales stage. |
| Engagement Concentration | Shows whether engagement depends on one contact rather than several stakeholders. |
| Executive Engagement Tracker | Shows when senior stakeholders last engaged and identifies expected executive roles without a recorded relationship. |
| Open Issues Risk | Highlights potential risk based on the number, priority, and age of open support cases. |
| Service Health Summary | Summarizes open cases, the most urgent cases, and recurring cases for the account. |
| Stakeholder Change Alerts | Identifies contact additions, departures, and role changes recorded in Dataverse. |
| Win Rate | Shows the percentage of closed opportunities won by the account over the past 12 months, compared with your organization's average. |

### Interpret insight results

Check these limitations when you assess a result. Use service-risk signals to decide which cases to inspect, not as evidence that someone escalated or resolved a case.

| Consideration | What to know |
| --- | --- |
| Recorded data | Built-in preview insights use Dynamics 365 data stored in Dataverse. They don't directly read untracked Outlook, Teams, or LinkedIn activity and might not reflect all customer activity. |
| Calculation time | Changes made after the **As of** timestamp might not appear in the result. |
| Copilot credits | Calculating insights in this preview uses your organization's Copilot credits; viewing them doesn't. If credits run out, insights keep their last result and **As of** timestamp until more credits are available. |
| Meeting records | Completed appointments can identify invited contacts but don't confirm attendance. Insights might not count meetings that are still scheduled or aren't tracked in Dataverse. |
| Stakeholder changes | Alerts depend on recorded contact changes and available audit history. Dates indicate when Dataverse recorded the change, not necessarily when the person changed roles. |
| Limited history | Too few opportunities, meetings, or qualifying activities might prevent a result, percentage, or trend. A missing result doesn't necessarily mean there's no risk. |

If a result appears incomplete, check the related records or ask your administrator to review data availability and configuration.

## Related information

- [Use the canvas experience for contacts](use-contact-canvas.md)
- [Manage your accounts and contacts](../sales/accounts-contacts.md)
- [Insights overview for administrators](insights-overview.md)
- [Set up and configure insights](set-up-configure-insights.md)
- [Create and manage custom insights](create-manage-custom-insights.md)
