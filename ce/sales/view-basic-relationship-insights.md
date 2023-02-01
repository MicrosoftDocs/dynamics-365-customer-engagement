---
title: View basic relationship insights 
description: Basic relationship insights are generated out-of-the-box by using emails and appointments sent and received from Dynamics 365. 
ms.date: 01/30/2023
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
ms.custom: bap-template #Required; don't change.
---

# View the basic relationship insights  

Basic relationship insights are generated out-of-the-box by using emails and appointments sent and received from Dynamics 365. Relationship analytics use seller-customer interaction history to calculate KPIs and understand who knows whom. 

The basic insights are available by default and do not require any configuration. To get additional insights based on emails and meetings information in Exchange, your organization must have a Sales Premium license and your administrator must configure relationship intelligence with Exchange integration. More information: [Enable relationship intelligence](enable-ri.md).

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|

## View relationship analytics and KPIs

Relationship analytics and KPIs are available for contacts, accounts, leads, and opportunities. The following section describes the steps for accessing the analytics page for contacts. You can use similar steps for viewing relationship analytics for accounts, leads, and opportunities.

1. In the Sales Hub app, select **Contacts** and open a contact.  
1. Select the **Sales Insights** form from the drop-down.  
    :::image type="content" source="media/sales-insights-form.png" alt-text="Screenshot of the drop-down to select the Sales Insights form":::
1. Select the **Relationship Analytics** tab.
    The tab includes various widgets with several useful insights.


## View who knows who information

The who knows whom information is available for Contact and Lead entities. Open a contact or lead to view the Who knows whom widget in the main Contact or Lead form, and in the Sales Insights form.

:::image type="content" source="media/who-knows-whom-widget.png" alt-text="Screenshot of the who knows whom widget in the contact form.":::

The widget lists users from your organization who have interacted with the selected contact or lead. For information about how the connection strength is calculated, see [How are the connections weighted?](faqs-sales-insights.md#how-are-the-connections-weighted). 


