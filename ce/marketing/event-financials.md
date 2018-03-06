---
title: "View and record financial information for events (Dynamics 365 for Marketing) | Microsoft Docs "
description: "Learn how and where to record values for various budgets, expenses, and revenue for events in Dynamics 365 for Marketing"
keywords: "designer; email; preview; template; Litmus"
ms.date: 04/01/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 81db7e88-22fb-498c-b4aa-909c844886c3
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Record and view financial information for events

Dynamics 365 for Marketing enables you to record financial information related to your events. You can:
- Record speaker costs (standard cost or for a specific engagement)
- Record venue costs (standard cost or for a specific event)
- Record sponsorship income for an overall event sponsorship
- Record individual sponsored articles, with the total cost of all sponsored articles calculated for an event.
- Record prices for event passes
- View high-level financial data for an event combined with calculated values for the venue costs and sponsorship income.

## Record speaker costs

To record a speaker's standard fee:

1. Go to **Events** > **Participants** > **Speakers**.
1. Open or create a speaker record.
1. Set the **Speaker cost** on the **General** tab to the standard price usually requested by that speaker.

To record a speaker's fee for a specific engagement:

1. Go to **Events** > **Event** > **Event**.
1. Open or create an event record.
1. Go to the **Agenda** tab of the event record.
1. Under the **Speaker engagement** section, open or create a speaker engagement.
1. On the **General** tab of the speaker-engagement record, set the **Speaker cost** to the price that applies to this engagement.

## Record venue costs

To record a venue's standard cost:

1. Go to **Events** > **Venue management** > **Venues** (for a venue or sub-venue) or **Events** > **Venue management** > **Buildings** (for a building). (You can't specify prices for individual rooms).
1. Open or create a venue or building record.
1. On the **General** tab of the venue or building record, set the **Cost** to the standard price normally charged for that venue or building.

To record a venue's cost for a specific event:

1. Go to **Events** > **Event** > **Event**.
1. Open or create an event record.
1. Go to the **Financials** tab of the event record.
1. The **Event venue cost** field initially shows the cost of the main venue selected for the event. If your price is different for this event, then edit this value as needed. (The initial value doesn't roll up the individual costs of sub-venues, if available—it only shows the cost of the main venue itself.) Once edited, this value no longer tracks the cost of the event's venue  (delete the value to reset).

## Record sponsorship revenue

There are several types of sponsorships, including monetary, services, and equipment. Of these, you can only record revenue for sponsorships where the **Sponsorship type** is set to **Monetary**.

To record revenue from a sponsorship:

1. Go to **Events** > **Sponsorship management** > **Sponsorships**.
1. Open or create a sponsorship record.
1. Make sure that **Sponsorship type** is set to **Monetary**.
1. Set the **Sponsorship amount** to the price this sponsor has agreed to pay to sponsor your event.

To view or record the total sponsorship revenue for an event:

1. Go to **Events** > **Event** > **Event**.
1. Open or create an event record.
1. Go to the **Financials** tab of the event record.
1. The **Revenue from sponsorship** field initially shows the sum of amounts from all sponsorships associated with the current event. If your total revenue is different from this, then you can edit the value as needed. Once edited, this value no longer tracks the total amounts from all sponsorships (delete the value to reset).

## Record the cost of sponsored articles

Sponsored articles are typically event facilities or give-aways that are sponsored by an external company. If your organization pays for the articles, then you can record their cost to you in the relevant sponsored article record. Each sponsored article record is associated with a parent sponsorship record, where you can record the revenue for the sponsored articles.

To record the cost of a sponsored article:

1. Go to **Events** > **Sponsorship management** > **Sponsorable articles**.
1. Open or create a sponsorable articles record.
1. Make sure that a parent **Event sponsorship** record is identified. This is where you should record any revenue associated with this sponsorable articles record.
1. Set the **Number of units** to the number of units included in the deal.
1. Set the **Cost per unit** to your price for each unit.

Note that the total cost for the sponsored article is computed for you and displayed in the **Total cost** field.

## Record prices for event passes

In addition to sponsorships, you can also gain revenue from an event by charging attendees for admission. You manage this by setting up event passes, which function as tickets to your event.

To assign a price to an event pass:

1. Go to **Events** > **Event** > **Event**.
1. Open or create an event record.
1. Go to the **Registration and attendance** tab of the event record.
1. Find the **Pass** section of the **Registration and attendance** tab. Here you can view and create each type of pass that is available for the event.
1. Open or create a pass in the **Pass** section.
1. Set the **Pass price** to the price of the pass.

## Record and review overall event financial data

Each event record provides a Financials tab where you can view and record financial details for the event. The following values are provided here:

- **Target revenue**: Records an estimate for the total revenue from pass sales, sponsorships, and elsewhere. This can be useful during budget planning. This field is not calculated, so you can enter any value you want.
- **Total registration fee (package cost)**: Records the total registration fee.  This field is not calculated, so you can enter any value you want.
- **Event venue cost**: Initially tracks the standard cost of the main venue assigned for the event, as recorded in the venue record. However, the default does not include rolled-up costs of sub-venues or other costs. You can edit this value if needed, but once edited it will stop tracking the cost of the main venue (delete the value to reset).
- **Miscellaneous costs**: Records any miscellaneous costs. This field is not calculated, so you can enter any value you want.
- **Total revenue from the event**: Records the total actual revenue from the event according to your records. This field is not calculated, so you can enter any value you want .
- **Currency**: Specify the currency you are using for all the other values on this page.
- **Budget allocated**: Records the total amount you intend to spend on the event. This field is not calculated, so you can enter any value you want.
- **Total cost of external members**: Records the total cost of external members. This field is not calculated, so you can enter any value you want.
- **Total cost of event activities**: Records the total cost of event activities. This field is not calculated, so you can enter any value you want.
- **Revenue from sponsorship**: Initially tracks and adds together the revenue specified for each sponsorship associated with this event. You can edit this value if needed, but once edited it will stop tracking the revenues of associated sponsorship records (delete the value to reset).


