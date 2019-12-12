---
title: "Work with segment templates (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to create, manage, and use segment templates in Dynamics 365 Marketing"
ms.date: 12/10/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Work with segment templates

Like many entities in Dynamics 365 Marketing, segments support templates, each of which provides an initial collection of settings that help users get started creating common types of segments more quickly.

## Create a segment based on a template

Each time you create a new segment, the **Segment templates** dialog box opens, showing a list of available templates. Each template provides a fully or partially defined query designed for a particular purpose, as indicated by the template name. Select any template to read more information about it in the information panel. **Filter** and **Search** features are provided to help you find the template you're looking for. Select a listed template and then choose **Select** to load the that template, or choose **Cancel** to start [building a new segment from scratch](segmentation-lists-subscriptions.md).

![Choose a segment template](media/segment-choose-template.png "Choose a segment template")

## Manage your segment templates

All of the segments listed in the **Segment templates** dialog box can be found under **Marketing** > **Marketing templates** > **Segment templates**, which provides a list of available templates. 

To edit a listed template, select it and then choose **Edit** on the command bar (or double-click a listed template). Then edit the template just as you would a [standard segment](segmentation-lists-subscriptions.md) of that type.

To delete a listed template, select it and then choose **Delete** on the command bar (or double-click a listed template).

Each template listed on the **Active segment templates** view will be shown in the **Segment template** dialog box each time a user creates a new segment. Templates listed on the **Inactive segment templates** view are saved, but not shown in the **Segment template** dialog box. To change the activation status of a template, select the target template and then use the **Activate** and **Deactivate** buttons on the command bar to set its activation status.

## Create a new template

To create a new template, go to **Marketing** > **Customers** > **Templates** and [create a standard template as usual](segmentation-lists-subscriptions.md) . When your template is ready, select **Save as template** on the command bar. A flyout slides in from the side of your screen. Use it to name and describe your template and select **Save and close** to add it to your template collection.

## Manage template descriptions and metadata

The information shown for each template in the **Segment templates** dialog box comes directly from the template itself. You can find these values on the **General** tab of each template.

## Standard templates

Dynamics 365 Marketing comes with a collection of standard templates designed to help get you started creating a variety of common segments. Each provides an initial query structure, but you'll usually need to finish the query by supplying the values you are looking for and/or by adding new rows and groups as needed.

The standard templates also provide good examples that can help you learn common techniques for designing your own segments.

You'll find the standard templates listed together with any custom templates you've created under **Marketing** > **Marketing templates** > **Segment templates**. You can freely customize, rename, and delete (or deactivate) the standard templates as needed.

## Template labels

As with other types of templates in Dynamics 365 Marketing, segment templates support adding visual labels that help users identify and find the templates they are looking for when using a template gallery or list. More information: [Work with email, page, and form templates](email-templates.md)

### See also

[Working with segments](segmentation-lists-subscriptions.md)  
[Design dynamic demographic or firmographic segments](segments-profile.md)  
[Design behavioral segments](segments-interaction.md)  
[Design static segments](segments-static.md)  
[Combine segments into a compound segment (combined audiences)](segments-compound.md)

