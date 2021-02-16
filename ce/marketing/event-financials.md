---
title: "View and record financial information for events in Dynamics 365 Marketing (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to record values for event budgets, expenses, and revenue in Dynamics 365 Marketing."
ms.date: 12/17/2018
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Record and view financial information for events

You can record financial information for your events with Dynamics 365 Marketing. For example, you can:

- Record speaker costs (standard cost or for an engagement).
- Record venue costs (standard cost or for an event).
- Record sponsorship income for event sponsorship.
- Record individual sponsored articles, with the total cost of all sponsored articles calculated for an event.
- Record prices for event passes.
- View high-level financial data for an event combined with calculated values for venue costs and sponsorship income.

## Record speaker costs

To record a speaker's standard fee:

1. [Open the Events work area](open-events.md) and go to **Events** > **Participants** > **Speakers**.
1. Open or create a speaker record.
1. On the **General** tab, set the **Speaker cost** to the standard price usually requested by that speaker.

To record a speaker's fee for an engagement:

1. [Open the Events work area](open-events.md) and go to **Events** > **Event** > **Event**.
1. Open or create an event record.
1. Go to the **Agenda** tab of the event record.
1. Under the **Speaker engagement** section, open or create a speaker engagement.
1. On the **General** tab of the speaker-engagement record, set the **Speaker cost** to the price that applies to this engagement.

## Record venue costs

To record a venue's standard cost:

1. [Open the Events work area](open-events.md) and go to **Events** > **Venue management** > **Buildings**.
    > [!NOTE]
    > You can't specify prices for individual rooms.
1. Open or a building record.
1. On the **General** tab of the venue or building record, set the **Cost** to the standard price normally charged for that venue or building.

To record a venue's cost for an event:

1. [Open the Events work area](open-events.md) and go to **Events** > **Event** > **Event**.
1. Open or create an event record.
1. Go to the **Financials** tab of the event record.
1. The **Event venue cost** field shows the cost of the main venue selected for the event. If your price is different for this event, then edit this value as needed. After you edit the value, it no longer automatically tracks the cost of the event venue. Delete the value to reset.
    > [!NOTE]
    > This value doesn't roll up the individual costs of sub-venues, if available&mdash;it only shows the cost of the main venue.

## Record sponsorship revenue

There are several types of sponsorships, including monetary, services, and equipment. Of these, you can only record revenue for sponsorships where the **Sponsorship type** is set to **Monetary**.

To record revenue from a sponsorship:

1. [Open the Events work area](open-events.md) and go to **Events** > **Sponsorship management** > **Sponsorships**.
1. Open or create a sponsorship record.
1. Make sure that **Sponsorship type** is set to **Monetary**.
1. Set the **Sponsorship amount** to the price this sponsor has agreed to pay to sponsor your event.

To view or record the total sponsorship revenue for an event:

1. [Open the Events work area](open-events.md) and go to **Events** > **Event** > **Event**.
1. Open or create an event record.
1. Go to the **Additional information** tab of the event record and find the **Financials** section.
1. The **Revenue from sponsorship** field shows the sum of all sponsorship revenue associated with the event. If your total revenue is different from this, you can edit the value as needed. After you edit the value, it no longer tracks the totals from all sponsorships. Delete the value to reset.

## Record the cost of sponsored articles

Typically, sponsored articles are event facilities or giveaways that are sponsored by an external company. If your organization pays for the articles, you can record the cost in the relevant sponsored article record. Each sponsored article record is associated with a parent sponsorship record, where you can record revenue for the sponsored articles.

To record the cost of a sponsored article:

1. [Open the Events work area](open-events.md) and go to **Events** > **Sponsorship management** > **Sponsorable articles**.
1. Open or create a sponsorable articles record.
1. Make sure that a parent **Event sponsorship** record is identified. This is where you should record any revenue associated with this sponsorable articles record.
1. Set the **Number of units** to the number of units included in the deal.
1. Set the **Cost per unit** to your price for each unit.

Note that the total cost for the sponsored article is computed for you and displayed in the **Total cost** field.

## Record prices for event passes

In addition to sponsorships, you can gain revenue from an event by charging for admission. Manage this by setting up event passes, which function as tickets, to your event.

To assign a price to an event pass:

1. [Open the Events work area](open-events.md) and go to **Events** > **Event** > **Event**.
1. Open or create an event record.
1. Go to the **Registration and attendance** tab of the event record and find the **Passes** section. Here you can view and create each type of pass that is available for the event.
1. Open or create a pass in the **Pass** section.
1. Set the **Pass price** to the price of the pass.

## Record and review overall event financial data

Each event record provides an **Additional information** tab that includes a **Financials** section where you can view and record financial details for the event. Financial details include:

- **Target revenue**. Records an estimate of the total revenue from pass sales, sponsorships, and other revenues. This can be useful during budget planning. This field is not calculated, so you can enter any value you want.
- **Total registration fee (package cost)**: Records the total registration fee. This field is not calculated, so you can enter any value you want.
- **Event venue cost**. Tracks the standard cost of the main venue assigned for the event, as recorded in the venue record. However, the default does not include rolled-up costs of sub-venues or other costs. You can edit this value if needed, but once edited, it will stop automatically tracking the cost of the main venue. Delete the value to reset.
- **Miscellaneous costs**. Records any miscellaneous costs. This field is not calculated, so you can enter any value you want.
- **Total revenue from the event**. Records the total actual revenue from the event according to your records. This field is not calculated, so you can enter any value you want.
- **Currency**. Specify the currency you are using for all the values on this page.
- **Budget allocated**. Records the total amount you intend to spend on the event. This field is not calculated, so you can enter any value you want.
- **Total cost of external members**. Records the total cost of external members. This field is not calculated, so you can enter any value you want.
- **Total cost of event activities**. Records the total cost of event activities. This field is not calculated, so you can enter any value you want.
- **Revenue from sponsorship**. Initially tracks and adds together the revenue specified for each sponsorship associated with this event. You can edit this value if needed, but once edited it will stop automatically tracking revenues from associated sponsorship records. Delete the value to reset.


[!INCLUDE[footer-include](../includes/footer-banner.md)]