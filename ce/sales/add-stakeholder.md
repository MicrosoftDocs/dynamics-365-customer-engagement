---
title: "Add stakeholders, sales team, and competitors for the opportunity | MicrosoftDocs"
description: "Add people that you're working with on the opportunity as stakeholders and sales team."
ms.date: 04/05/2023
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-opportunity
  - D365-UI-*
  - Dynamics 365
  - Sales
---

# Add stakeholders, sales team, and competitors for the opportunity

When you're working on an opportunity, you'll be interacting with several people, both internally and externally. These people are broadly categorized as stakeholders, sales team, and competitors. Capturing information about the people that you're working with on the opportunity helps your leadership team understand how the opportunity is shaping up and where you need help.  

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Sales Professional  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|
 
## Add stakeholders and decision makers for the opportunity

A stakeholder can be a decision maker or any person who's working with you on the opportunity from the customer's end, such as a champion, end user, economic buyer, influencer, or technical buyer.  

> [!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RE4U5N2]

**To add stakeholders:**

1. In the Sales Hub site map, select **Opportunities**.

1. Open the opportunity.
1. In the **Summary** tab, go to the **Stakeholders** section.
    > [!NOTE]
    > If you'd selected a person in the **Contact** field of the opportunity, that contact is automatically added to the **Stakeholders** section.
1. Select **New Connection** and then select the stakeholder's record from the contacts list.

    > [!NOTE]
    > The **New Connection** button is supported only for the out-of-box Stakeholders and Sales Team views on the Opportunity entity. If you're using custom views, the **New Connection** button doesn't appear on the sub-grid. In such cases, navigate to the Connection Associated view for the record and use the **Connect** button to create a new connection. More information: [How are stakeholders and sales team members tracked for opportunities?](stakeholders-sales-team-members.md)

    The selected contact is added as a stakeholder. 
1. To convert a stakeholder to any other stakeholder category (for example, decision maker), select the stakeholder record and then select **Edit**.
1. In the **As this role** field, remove Stakeholder and select a role that best fits the contact. For example, select Decision Maker if the contact is a decision maker for the opportunity.  
1. Go back to the opportunity and verify that the stakeholder's role is updated.  

## Add sales team for the opportunity

If multiple users and teams from your organization are working on an opportunity, add them as the Sales team for the opportunity. After you add them, the sales team members will be able to see the opportunity in their **Opportunities I am a member of** view.  

**To add the sales team:**

1. In the Sales Hub site map, select **Opportunities**.

1. Open the opportunity.
1. In the Summary tab, scroll down to the **Sales team** section.
1. Select **New Connection** and then add users or teams in your organization who are involved in the opportunity. 
    > [!NOTE]
    > If you don't see the **New connection** button, navigate to the Connection Associated view for the record and use the **Connect** button to create a new connection. More information: [How are stakeholders and sales team members tracked for opportunities?](stakeholders-sales-team-members.md)


## Add competitors for the opportunity

Add the organizations that are competing with you for the opportunity as competitors for the opportunity.  

> [!NOTE]
> The competitors entity is not supported for Sales Professional license.  

**To add competitors:**

1. In the Sales Hub site map, select **Opportunities**.

1. Open the opportunity.
1. In the Summary tab, scroll down to the **Competitors** section.
1. Select **Add Existing Competitor** to add a competitor.

### See also

[Create or edit opportunities](create-edit-opportunity-sales.md)  
[Move the opportunity through different stages](move-opportunity-stages.md)   
[Troubleshoot issues with opportunities](/troubleshoot/dynamics-365/sales/troubleshoot-opportunities-issues#stakeholder-and-sales-team-subgrids)