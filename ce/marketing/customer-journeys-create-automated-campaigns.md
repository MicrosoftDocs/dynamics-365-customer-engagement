---
title: "Guide your prospects through an interactive customer journey (Dynamics 365 for Marketing) | Microsoft Docs "
description: "How to create a customer journey by assembling a pipeline of automated communications, activities, and conditional pathways in Dynamics 365 for Marketing"
keywords: "customer journey; campaign; email; segment; go live; pipeline"
ms.date: 04/01/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: dd5579ea-7fea-41fa-81ab-a83d67943c7e
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Use customer journeys to create automated campaigns

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

<div class="embeddedvideo"><iframe src="https://go.microsoft.com/fwlink/p/?linkid=863167" frameborder="0" allowfullscreen></iframe></div>

Use [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] to visualize and automate the journey that customers will take while interacting with your marketing initiatives on their way to making a purchase. A simple customer journey might include just a short interaction, such as a single email campaign. A complex journey could include the full process from discovery, through nurturing, and on to marketing-qualified leads. Customer journeys can also generate and assign [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] tasks (such as a scheduled follow-up phone call), and trigger business workflows.

[!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] provides a graphical, drag-and-drop, journey modeler that works something like a simple board game. Each contact starts on the first square (by becoming part of a target segment), and then progresses through one square at a time, with each square representing a marketing initiative, decision point, or internal action item.

![An example of a customer journey](media/customer-journey.png "An example of a customer journey")

The previous figure shows how a simple customer journey might look in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. A somewhat more complex example could work like this:

1. A new contact from New York wants to subscribe to your newsletter, and fills out a marketing page on your site. This results in a new contact record in your database.

1. You have a dynamic segment that finds all newsletter subscribers from New York, so the new contact automatically joins that list.

1. You've created a customer journey in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] that starts with the New York subscribers' segment as tile one, so the contact starts there and moves directly to the next tile.

1. The next tile in the journey is an email tile, so the system automatically sends a marketing email to the new contact, and the contact moves on to the next tile. The email message offers a free white paper for download.

1. The next tile is a trigger (set to trigger on the email). It keeps the contact here until either a week goes by, or they click the download link. The trigger branches the path, so if the contact clicks to download the paper, they'll take the "true" path immediately; but if a week goes by without a click, they'll go down the "false" path.

1. The top ("true") path continues with more tiles designed to nurture the lead further. Because the contact clicked the link, [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] generated a lead for that contact, which represents their expression of interest in the product promoted in that white paper. Some tiles along this path might initiate or evaluate lead interactions (such as surveys or event invitations), while others might generate internal events (like assigning a task or launching a workflow in the CRM system). As the contact interacts with your initiatives, the lead builds up its score until it's ready to forward to sales.

1. The bottom ("false") path starts with another email tile, which sends a reminder with a second chance to get the download, after which the contact might continue down the same type of nurturing path if they respond, or get dropped for now if they don't.

## Set up a customer journey

To view and create your customer journeys, go to **Marketing** &gt; **Marketing Execution** &gt; **Customer Journeys**. This brings you to a standard list view, where you can search, sort, and filter the list to find an existing journey—or create a new one by using the commands in the command bar.

When you create a new customer journey, you'll first be presented with a list of customer-journey templates, which can help you get started quickly. The **Select a Journey Template** dialog box provides a categorized overview of templates and a search form to help you find the one you're looking for. Each template represents a particular type of campaign, and includes a preconfigured pipeline and a few related settings that will help you create a customer journey of the selected type.

![Select a Journey Template dialog](media/customer-journey-template.png "Select a journey template")

You can also choose to start from scratch instead of using a template. The pipelines provided by a template represent the form and logic of your campaign, but you'll still need to configure the various tiles by&mdash;for example&mdash;assigning the specific marketing email message that should be sent by each email tile.

When creating or editing a customer journey, you'll be working on the customer-journey form page. At the top of this page, you'll see the canvas, where you'll build up your campaign pipeline by adding, arranging, and configuring the tiles that represent each step in the journey. General settings and fields for metadata are available further down on the page, below the canvas.

## Design your journey

Use the **Design** tab to design your campaign by arranging tiles into a logical flow, and then configure each tile.

### Working with tiles and the pipeline

You can add tiles to the pipeline by dragging tiles from the **Toolbox** tab on the right side of the canvas to the appropriate position on the canvas. You can also add tiles by using the command bar and arrow keys, as described in the next section.

![Drag a tile from the Toolbox to the canvas](media/cj-drag-ill.png "Drag a tile from the Toolbox to the canvas")

The first tile in the pipeline establishes the target segment for the customer journey. This is what determines which contacts get sent down the pipeline. You'll typically start with a segment tile, which finds contacts based on a logical query (a dynamic list) or on a static list, where individual contacts are added and removed manually. You might create dynamic lists based on demographic information (such as finding contacts from New York City), whereas a static list might represent a subscription list that contacts can add themselves to or remove themselves from by using one of your subscription center webpages.

After they are added, most tiles provide features such as those illustrated in the following figure.

![Features of a customer-journey tile](media/cj-tile-features-ill.png "Features of a customer-journey tile")

Legend:

1. **Tile type**: Shows what type of tile it is (segment, email, trigger, and so on). The icon and color also indicate this.
1. **Tile name**: Shows the name assigned to this particular tile.
1. **Tile status**: Shows key statistics about the tile, such as how many contacts are waiting here or how many messages it has sent so far. The information shown varies by tile type.
1. **Expand button**: Some types of tiles can include child tiles, which are shown nested below their parent tile. Select the expand button to open or close the child-tile display. Tiles that don't accept child tiles don't show a button here.
1. **Child tiles**: You can view, select, configure, or remove existing child tiles here when the parent tile is expanded. You can add new child tiles by dragging them here or to the parent tile (this also works when the parent is collapsed).

To configure a tile or child tile, select it in the pipeline and then go to the **Properties** tab to the right of the canvas, where you'll find all the settings that apply to the type of tile you've selected.

### Add tiles by using the command bar and arrow keys

Though most people add and arrange tiles by dragging them to the canvas, you can also do it by using the toolbar above the canvas, and you can even build up a pipeline without using the mouse at all. This makes the solution more adaptable to your working preferences while also making it more accessible for people who have trouble working with a mouse.

1. Select **Add** in the command bar to open the add-tile drop-down list. You can also select the Tab key until the **Add** button is highlighted or its name is read aloud by a screen reader.

1. Choose the type of tile you want to add from the drop-down list by using your mouse, or by using the arrow keys and the Return key.

    ![Add a tile from the toolbar](media/cj-add-menu-ill.png "Choose the type of tile you want to add")

1. The pipeline is now updated to show all the available insertion points where you can drop your new tile. Use your mouse, or arrow keys and Return key, to choose the location and drop the tile there.

    ![Choose where to add the new tile](media/cj-add-location-ill.png "Choose where to add the new tile")

### Configure tile settings

Each tile represents a step in the customer journey, and you'll make configuration settings to establish what happens at each of these steps. Most types of tiles interact with some other type of record in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], such as a target segment, marketing email message, landing page, event, or action. Other types of tiles&mdash;like schedulers, triggers, and splitters&mdash;react to things that happen during the journey itself and control the path that each contact takes when these things happen.

To configure a tile, select it in the pipeline, and then go to the **Properties** tab to the right of the canvas, where you'll find all the settings that apply to the type of tile you've selected. When you add a new tile, its **Properties** tab is automatically activated so you can start configuring that tile right away.

For tiles that must refer to some other record in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], like emails or events, you can choose to leave the record unspecified, choose an existing record, or create a new record to use with that tile. All tiles of this type include the **Properties** settings highlighted in the following figure.

![An example of common tile settings](media/cj-tile-details-ill.png "An example of common tile settings")

Legend:

1. **New**: Creates a new record of the type required by the current tile. Select to open the quick-create flyout, which slides in at the top of the screen and requests values for all the required and most-import settings for your new record. When you complete the quick-create form, your new record will exist and be linked to your tile, but probably will require more work before you can use it. You might choose to finish it now by selecting **Edit** to open the full form for the record, or you could leave it for later and instead continue to concentrate on building the structure of your customer journey for now.
1. **Search button**: Select to find an existing record of the type required by the current tile. To narrow the search, start by entering part of the record name you are looking for in the field next to the search button, and then select the button.
1. **Current record**: If the tile is already configured, this shows the name of the record associated with the current tile. As mentioned, you can also use this as a search field, together with the search button, to look for other existing records.
1. **Edit**: If the tile is already associated with a record, select to open the full form for that record. From there, you'll have full access to all that record's information and settings.

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Customer journey tiles reference](customer-journey-tiles-reference.md)

### Create activity marketing templates for activity tiles

The activity tile enables a customer journey to generate [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] an activity record (such as a phone call, task, or appointment), associate the activity with each contact who enters the tile, and assign each activity to a [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] user for follow-up. Each activity tile uses an activity marketing template to define the type and details of the activities it generates.

To view, edit, and create an activity marketing template, go to one of the following areas, depending on which type of activity you are setting up:

- For phone-call activities, go to
 **Templates** &gt; **Phone Call Activity Marketing Templates**.
- For task activities, go to
 **Templates** &gt; **Task Activity Marketing Templates**.
- For appointment activities, go to
 **Templates** &gt; **Appointment Activity Marketing Templates**.

In each case, you'll go to a list showing templates of your selected type. The list includes the usual controls to search, sort, and filter the list, and to add or remove templates.

All types of activity marketing templates have the following required settings:

- **Name**: This is the name you'll see when assigning the template to an activity tile.
- **Owner**: This is the [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] user who owns the template. Note that the user the activity gets assigned to is established by the settings for the tile that uses the template.
- **Subject**: This is the subject shown on each activity record generated by using this template.

Other settings for activity marketing templates vary by activity type and, like the **Subject**, are saved with each activity generated by using the template. These other settings map to those used by the activity records themselves.

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Action tiles](customer-journey-tiles-reference.md#action-tiles)

## Set general options, including execution schedule and content settings

Use the **General** tab to give your journey a name, assign ownership, set its execution schedule, choose content settings, view its timeline history, and more.

### Set the execution schedule

All customer journeys are active for a limited time. During this time, the journey processes all contacts that are part of its target segments, stepping them through each tile according to its settings. The journey starts by processing all contacts that are already in its segments, and it will continue to process new contacts that are added to the segment during the time it is active. At the end of the schedule, it stops processing all contacts, regardless of where they are in the journey. Use the **Start date and time** and **End date and time** settings on the **General** tab to set up the start and end dates, and use the **Time zone** setting to establish the time zone to use when interpreting these values.

### Set up a recurring journey

Usually, the journey takes each contact through its pipeline exactly once. Even if you use several segments, and a given contact appears in more than one of them, each contact is processed at most once. However, you can also set up a recurring journey in which all contacts are reprocessed at a regular interval during the active period. To set up a recurring journey:

1. Open your journey and go to the **General** tab.
1. Set **Is recurring** to **Yes**. This opens two additional settings here.
1. Set the **Recurrence interval** to the number of days each iteration should last.
1. Set the **Recurrence count** to the maximum number of recurrences each contact can experience.


> [!NOTE]
> Your recurrence schedule must fit within your start and end dates, such that:  
**interval * count &le; end date &ndash; start date**.

### Choose your content settings

Content settings are sets of standard and required values that are available for use in marketing email messages. Each includes a subscription-center link, a forward-to-a-friend link, social-media links, your postal address, and other information that can be placed into the message as dynamic values by using the assist-edit feature. You'll set up each customer journey to use a specific content-settings record, which means that all messages sent by that journey will use the same content settings. However, each journey can use a different content-settings record, which means that you can use an identical marketing-email design in two or more customer journeys, each specifying a different set of content settings. 

To choose the content settings used by a journey, go to its **General** tab and make a selection for the **Content settings** field.

For more information about how to create and configure content-settings records, see [Use content settings to set up repositories of standard and required values for email messages](prepare-marketing-emails.md#content-settings)

If you have more than one set of content settings, exactly one of them will be the default and will be applied automatically to each new customer journey that you create. For more information about how to establish the default content-settings record for new journeys, see [Default marketing settings](marketing-settings.md#default-marketing-settings).

### Add a suppression segment

A journey's suppression segment contains a list of contacts that the journey won't send any messages to, even if those contacts are also included among the segments explicitly targeted by the journey, and even if those contacts are already partly through the journey. 

You can use any existing segment as a suppression segment. To choose a suppression segment for your journey, open its **General** tab and then choose a segment in the **Suppression segment** lookup field.

## Go live to start running the journey and processing contacts

When you first create a new customer journey, and while you're working on it, the journey stays in Draft status. (The status is displayed above the journey canvas in the **Status Reason** field.) While it's still in draft status, the journey is inactive and it won't try to send any messages or do any other processing. When everything's in place and you're ready to start running the journey, you publish it. This updates the journey's **Status Reason** to Published, and as soon as the specified **Start Date** arrives, the journey will start processing all contacts in its target segment.

When you've finished designing your customer journey, do the following to verify and publish it:

1. Double-check the **Start Date** and **End Date** on the **General** tab. The customer journey won't do anything until the **Start Date** arrives and it will stop processing all contacts, no matter which tile they're on, as soon as the **End Date** arrives. Remember also that any contact who joins the target segment while a journey is running will also be processed by that journey, starting at the first tile.

1. Select **Check for Errors** in the command bar to verify your campaign setup and check it for errors. This step makes sure that all required marketing emails and pages are assigned and published, and also checks for other prerequisites and common errors. If problems are found, you'll see an error message with advice for how to fix it. Continue to check, fix reported errors, and check again until your journey passes the test.

1. Now you're ready to publish: select **Go Live** in the command bar. [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] runs the error check one last time. If your journey passes, it is published to the active area of your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] server, which also hosts your published marketing email messages and marketing pages.

### See also

[Customer journey tiles reference](customer-journey-tiles-reference.md)  
[Create a simple customer journey](create-simple-customer-journey.md)  
[Create an interactive customer journey](create-interactive-customer-journey.md)  
[Create an inbound customer journey](create-inbound-customer-journey.md)  
[Generate activities from a customer journey](generate-activities-from-customer-journey.md)  
[Segmentation, lists, and subscriptions](segmentation-lists-subscriptions.md)