---
title: Focused view FAQs
description: Get answers to frequently asked questions about focused view.
ms.date: 03/27/2024
ms.topic: troubleshooting
author: udaykirang
ms.author: udag
ms.owner: shujoshi
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/11/2024
---

# Focused view FAQs

This article answers frequently asked questions about focused view in Dynamics 365 Sales, Sales premium, and Sales professional.

## Is there any administration setup required to use focused view?

No. Focused view is available out of the box and doesn't require any setup. However, if it's disabled, an administrator can enable it. More information: [Configure focused view as default](set-focused-view-as-default.md).

## Why isn't the focused view opening by default for leads?

The following list includes the possible reasons why the focused view isn't opening by default for leads:

- Your administrator has set a custom data set as the default for the lead entity, and the focused view will not override this. If you want the focused view to be the default, you must update this customization to set the focused view as the default, or remove the existing customizations.
- After enabling early access, if you switch to a different grid using the **Show as** option, focused view remembers the most recently used option for that entity type and opens it the next time. To resolve this, select **Show as** > **Focused view** to open the focused view.
- Your administrator would have disabled focused view for leads. More information: [Enable focused view for all records](enable-focused-view.md)  

## Is focused view available on custom apps?

Yes, focused view is available on custom apps. To configure focused view as the default, see [Configure focused view as default for other entities](set-focused-view-as-default.md#configure-as-default-for-other-entities).

## How is focused view different from the system and user created views?

Focused view is a new entity layout similar to the current default grid layout, which helps the users to view all the assigned records in one area similar to the Sales accelerator workspace. More information: [Understand the focused view](focused-view.md#understand-the-focused-view)

## What all views can I see in focused view?

You can see all the system and user created views that are available in the grid layout.

## What are the filter capabilities available in focused view?

All filter options are available in focused view including the advanced filter option where you can create conditions to filter. More information: [Filter records in focused view](focused-view.md#understand-the-focused-view)

## How can I disable focused view in my organization?

To disable the focused view in your organization, an administrator must sign into the Power Apps portal and turn off the toggle for the **Enable focused view for all records** option. More information: [Enable focused view](enable-focused-view.md#enable-focused-view)

## Is focused view available for custom entities?

Yes, focused view is available for all entities. To configure focused view as the default for custom entities, see [Configure focused view as default for other entities](set-focused-view-as-default.md#configure-as-default-for-other-entities).

## Why the grid opens in focused view when I open an entity?

By default, the lead entity grid opens in focused view. Also, your administrator can configure to set focused view as default for other entities such as Account, Contact, Opportunity, and custom. More information: [Open the focused view](focused-view.md#open-the-focused-view).

## Why can't I see the focused view option in dashboards and sub-grids?

Focused view is available only on main grids and not supported in dashboards and sub-grids.

## How can I see other views in an entity and change from the focused view?

If there are multiple views available for an entity, you can find them under the **Show As** option. However, if there's only one view available, you'll see the **Read Only Grid** option. More information: [Switching a view](focused-view.md#understand-the-focused-view) 

## Why don't I see focused view even if it's default for an entity?

The focused view option might have been disable in your organization. Contact your administrator configure the focused view. More information: [Configure focused view as default](set-focused-view-as-default.md)

## Why did the customization on ribbon command bar change for me?

The command bar is added to the focused view to perform bulk actions on the records. More information: [Command bar](focused-view.md#open-the-focused-view)

## How can I change the Show As option position on the command bar or remove it from the ribbon bar?

You can't change the position of the **Show As** option on the command bar. However, you can remove it from the ribbon bar by disabling the focused view option. An administrator must sign into the Power Apps portal and turn off the toggle for the **Enable focused view for all records** option. More information: [Enable focused view](enable-focused-view.md#enable-focused-view)

## How do I keep focused view only for the entities I want and make it the default view? 

You can configure focused view as default for the entities you want. More information: [Configure focused view as default for other entities](set-focused-view-as-default.md#configure-as-default-for-other-entities).  
If already enabled, first disable the focused view feature in your organization and then configure the entities you want. 

## Can I make focused view as default for entities based on user role? 

No, you can't make focused view as default for entities based on user role. 

## Does a custom entity come with a focused view automatically when it's created?

No, a custom entity doesn't come with a focused view automatically when it's created. You can configure focused view as default for custom entities. More information: [Configure focused view as default for other entities](set-focused-view-as-default.md#configure-as-default-for-other-entities).

## Which entities have the Focused View feature available?

The focused view feature is available for all entities including custom entities. However, Activity entity doesn't have the focused view feature.

## What should I do if the grid doesn't show in Focused View after enabling it?

Delete the browser cache and refresh the page. 

## Why the web resource functions or custom renderings, which were added to my views, aren't working in focused view?

The web resource functions that you've added in your views are compatible only with the **Readonly grid** mode. They'll not work properly in focused view.