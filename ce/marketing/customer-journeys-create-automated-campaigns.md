---
title: "Guide your prospects through an interactive customer journey (Dynamics 365 Marketing) | Microsoft Docs"
description: "How to create a customer journey by assembling a pipeline of automated communications, activities, and conditional pathways in Dynamics 365 Marketing."
ms.date: 10/08/2020
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

# Use customer journeys to create automated campaigns

Dynamics 365 Marketing can help you visualize and automate the journey that customers take on their way to making a purchase. A simple customer journey could include a short interaction, such as a single email campaign. A complex journey might include the full process from discovery, through nurturing, and on to identifying qualified leads. Customer journeys can also generate and assign tasks (such as a scheduled follow-up phone call) and trigger business workflows.

Dynamics 365 Marketing provides a graphical journey modeler that works like a simple board game. Each contact starts on the first square (by becoming part of a target segment), and then progresses through one square at a time, with each square representing a marketing initiative, decision point, or internal action item.

![An example of a customer journey](media/customer-journey-full3.png "An example of a customer journey")

The previous figure shows how a simple customer journey might look. A more complex example could work like this:

1. A new contact from New York wants to subscribe to your newsletter and fills out a form on a marketing page. This results in a new contact record in your database.

1. A dynamic segment finds all newsletter subscribers from New York, so the new contact automatically joins that list.

1. You've created a customer journey that starts with the New York subscribers segment as tile one, so the contact starts there and moves directly to the next tile.

1. The next tile is an email tile, so the system automatically sends a marketing email to the new contact, and the contact moves on to the next tile. The email message offers a free white paper for download.

1. The next tile is an if/then (condition) tile. The tile keeps the contact here until either a week goes by, or the contact selects the download link. The if/then tile branches the path, so if the contact selects to download the paper, they'll take the "true" path immediately. But if a week goes by without the contact making a selection, the contact will follow the "false" path.

1. The top ("true") path continues with more tiles designed to nurture the lead further. Because the contact selected the link, Dynamics 365 Marketing generated a lead for that contact, which represents their expression of interest in the product promoted in the white paper. Some tiles along this path might initiate or evaluate lead interactions (such as event invitations), while others might generate internal events (like assigning a task or launching a workflow in the CRM system). As the contact interacts with your initiatives, the lead builds up its score until it's ready to forward to sales.

1. The bottom ("false") path starts with another email tile, which sends a reminder with a second chance to download the white paper, after which the contact might continue down the same type of nurturing path if they respond, or get dropped for now if they don't.

## Set up a customer journey

To view and create your customer journeys, go to **Marketing** > **Marketing Execution** > **Customer Journeys**. This brings you to a standard list view, where you can search, sort, and filter the list to find an existing journey.

To create a new journey, select **New** on the command bar.

When you create a new customer journey, you'll first be presented with a list of customer journey templates, which can help you get started quickly. The **Customer journey templates** dialog box provides a categorized overview of templates and a search form to help you find the one you're looking for. Each template represents a particular type of campaign and includes a pre-configured pipeline and a few related settings that will help you create a customer journey of the selected type.

![Select a Journey Template dialog](media/customer-journey-template.png "Select a journey template")

You can also choose to start from scratch instead of using a template. The pipelines provided by a template represent the form and logic of your campaign, but you'll still need to configure the various tiles by&mdash;for example&mdash;assigning the specific marketing email message that should be sent by each email tile.

When creating or editing a customer journey, you'll be working on the customer journey form page. On the first tab ("Designer"), you'll see the canvas, where you'll build up your campaign pipeline by adding, arranging, and configuring the tiles that represent each step in the journey. General settings and fields for metadata are available on the second tab ("General").

## Design your journey

Use the **Design** tab to design your campaign by adding tiles into a logical flow, and then configure each tile.

### Working with tiles and the pipeline

You can add tiles to the pipeline by selecting them from the **in-place menu** shown each time you select the "+" button on the canvas.

![Drag a tile from the Toolbox to the canvas](media/customer-journey-segment-start.png "Drag a tile from the Toolbox to the canvas")

The first tile in the pipeline establishes the target audience for the customer journey. This is what determines which contacts are sent down the pipeline. You'll typically start with a segment tile, which finds contacts based on a logical query (a dynamic segment) or on a static segment, where individual contacts are added and removed manually.

After you establish the target audience, most tiles provide features such as those illustrated in the following figure.

![Features of a customer-journey tile](media/customer-journey-tile-features2.png "Features of a customer-journey tile")

Legend:

1. **Tile type**: Shows what type of tile it is ("Send an email," "Wait for," "Phone call," and so on). The icon inside the tile also indicates the tile type.
1. **Entity name**: Shows the name assigned to a selected entity, for example, the name of the email ("Contoso Chairs").
1. **Tile configuration status**: Shows if the tile is configured already or not. The unconfigured status is indicated by a white-colored tile with a call to action (for example, "Choose an email"). A configured status is indicated by a colored tile with the selected entity name.

> [!NOTE]
> To create a condition based off of the element inside an email (such as checking if your recipient visited a Customer Voice survey linked inside your email), go to **Send an email** > **Properties** and select an appropriate element (such as a Customer Voice survey) inside the **Email elements** category.

For a complete list of available tiles and information about how to use them, see the [Customer journey tiles reference](customer-journey-tiles-reference.md).

### Add tiles using the arrow keys

Though most people add and arrange tiles by selecting them from the in-place menu using a mouse, you can also add tiles without using the mouse at all. The optional input methods make the customer journey designer more adaptable to your working preferences while also making it more accessible for people who have trouble working with a mouse.

1. Press the Tab key until the cursor moves into the canvas area and the **+** button is highlighted, or its name is read aloud by a screen reader.

1. Press the **Enter** key on your keyboard and choose the type of tile you want to add from the drop-down list using your mouse or arrow keys. After you select the tile, press the **Enter** key.

    ![Add a tile from the drop-down list](media/customer-journey-add-menu.png "Choose the type of tile you want to add")

1. The pipeline is now updated to show all the available insertion points where you can drop your new tile. Use your mouse or arrow keys and the Enter key to choose the location and drop the tile there.

More information: [Accessibility and keyboard shortcuts](designer-shortcuts.md)

### Configure tile settings

Each tile represents a step in the customer journey. You'll make configuration settings to establish what happens at each of these steps. Most tiles interact with some other type of record in Dynamics 365 Marketing, such as a target segment, marketing email message, event, or action. Other types of tiles&mdash;like wait tiles ("Wait for," "Wait until"), conditions ("If/then"), and splitters&mdash;react to things that happen during the journey itself and control the path that each contact takes when these things happen.

To configure a tile, select it in the pipeline, then go to the tile settings tab to the right of the canvas. The settings tab will show you all the settings that apply to the type of tile you've selected. When you add a new tile, its settings tab is automatically activated so you can start configuring the tile right away.

> [!NOTE]
> For live or stopped journeys, the tile settings are listed in the **Properties** tab to the right of the canvas.

For tiles that must refer to some other record in Dynamics 365 Marketing, such as emails or events, you can choose to leave the record unspecified, choose an existing record, or create a new record to use with the tile. All tiles of this type include the **Properties** settings highlighted in the following figure.

![An example of common tile settings](media/customer-journey-tile-details.png "An example of common tile settings")

Legend:

1. **New** actions are available when you select the search button then choose the new record you want to create ("New Marketing email," "New Appointment activity," and so on). "New" actions create a new record of the type required by the selected tile. Selecting a "new" action opens an in-place editor. The editor slides over the journey canvas, allowing you to create a new record, such as an email, without leaving the customer journey designer. When you finish creating your new record, the record will be linked to your selected tile.
1. **Search button**: Select to find an existing record of the type required by the current tile. To narrow the search, start by entering part of the record name you are looking for in the field next to the search button, then select the button.
1. **Current record**: If the tile is already configured, this shows the name of the record associated with the current tile. As mentioned, you can also use this as a search field, together with the search button, to look for other existing records.
1. **Edit**: If the tile is already associated with a record, select the record name to open the in-place form for editing that record. From there, you'll have full access to the record's information and settings.

More information: [Customer journey tiles reference](customer-journey-tiles-reference.md)

## Choose the journey's target segment

One of the most important choices you'll make when setting up a customer journey is deciding which of your contacts to include on the journey.

### Target a standard segment

The most common way to target a customer journey is to start with a segment tile, then choose a segment for it. You can combine several segments and choose the relevant logic for combining them (such as union/intersection or include/exclude).

- For information about how to create a segment, see [Working with segments](segmentation-lists-subscriptions.md)
- For information about how to configure a segment tile and set logic for combining segments, see [Customer journey tiles reference](customer-journey-tiles-reference.md#audience)

<a name="target-subscription-list"></a>

### Target a subscription list

All Dynamics 365 Marketing instances must provide a subscription center, which enables contacts to sign up for various mailing lists. You'll probably want to set up customer journeys to send messages to each of these mailing lists from time to time. To target a mailing list with a customer journey, place a segment tile configured to load a subscription list as the first tile in the journey. For more information about subscription lists and the subscription center, see [Set up subscription lists and subscription centers](set-up-subscription-center.md).

To set up a segment tile to target a subscription list:

1. Create a customer journey that targets an audience based off of a segment (segment being a source type of the audience).

1. Set the **Segment** field to **Subscription List**, which activates the **Look for Marketing list** field. Then use the **Look for Marketing list** field to find the subscription list you want to use for this journey.
  
    ![Set a segment tile to load a subscription list](media/customer-journey-subscription-list3.png "Set a segment tile to load a subscription list")

> [!IMPORTANT]
> When a customer journey targets a subscription list, any contact that unsubscribes from that list using a subscription center will automatically be removed from that journey within about 24 hours, even if they are already partway through it. However, if a user removes a contact from the list manually using the Dynamics 365 Marketing interface, that contact will continue to be processed by any journeys they already are on, and may continue to receive messages until all active journeys are complete. For this reason, it is usually best to request that all contacts manage their own subscriptions using the subscription center.

### Create an inbound customer journey

An inbound customer journey is one that contacts join by filling out an online form rather than being part of a target segment. To create an inbound journey, set the audience based on form submissions (set the "Source Type" to "Submitted a form") instead of a segment. Alternatively, you can create a segment configured to find contacts who submitted a particular form. More information: [Create an inbound customer journey](create-inbound-customer-journey.md)

<a name="general-options"></a>

## Set general options, including execution schedule and content settings

Use the **General** tab to give your journey a name, assign ownership, set its execution schedule, choose content settings, view its timeline history, and more.

### Target contacts or accounts

You must set each customer journey to target _either_ contacts _or_ accounts. Use the **Target** setting on the **General** tab to configure this option for each journey.

- When you target *contacts*, the journey will treat each contact as an individual, without considering the company (account) that the contact works for.
- When you target *accounts*, the journey can group contacts by the company (account) that each contact works for, which can affect the way contacts are processed as they traverse the journey, for example:
  - Trigger tiles can send all contacts from the same account down the same path.
  - Activity tiles can generate just one activity (such as a task or phone call) for each account, even if several contacts from that account are included in the journey.
  - Launch-workflow tiles can trigger their workflow once for each account, even if several contacts from that account are included in the journey.
  - Create-lead tiles can generate leads associated with accounts rather than contacts.
  - Journey insights shown in the **Data** panel can be filtered by account.

More information: [Account-based marketing](account-based-marketing.md)

### Set the minimum consent level

If data protection is enabled for your instance (for example, because you need to comply with the GDPR), then use the **Minimum consent** setting to control the minimum level of consent that each contact must have provided to be included on this journey. The level you choose should depend on the types of operations your journey will execute.

It is your organization's responsibility to ensure that it is operating in full compliance with all relevant data-privacy regulations when you use customer journeys and all other features of Dynamics 365 Marketing.

More information: [Data protection and the GDPR](gdpr.md)

### Set the business-unit scope

Business-unit scopes are an optional feature. When they are enabled for your instance, then the **General** tab includes a **Scope** setting, which controls which contacts will be permitted to join the journey based on business-unit ownership.

When business-unit scopes are enabled:

- The **Scope** setting is available and can have a value of **Organization** or **Business unit**. 
- **Business unit** scoped journeys will only process contacts that belong to the same business unit as the journey owner&mdash;even if the journey targets segments, lists, and/or pages that include contacts belonging to other business units.
- **Organization** scoped journeys will process all targeted contacts, regardless of which business unit owns the journey.
- Only users with organization-level create/update permissions can choose the **Organization** scope setting. Less privileged users are limited to creating journeys scoped at the **Business unit** level.

When business-unit scopes are disabled:

- The **Scope** setting isn't shown.
- All journeys are scoped at the organization level, which means that they will process all contacts in the targeted segments, lists, and/or pages, regardless of which business unit owns the journey and each contact.

More information: [Use business units to control access to Marketing records](business-units.md)

### Set the execution schedule

All customer journeys are active for a limited time. During this time, the journey processes all contacts that are part of its target segments, stepping them through each tile according to its settings. The journey starts by processing all contacts that are already in its segments, and it will continue to process new contacts that are added to the segment during the time it is active. At the end of the schedule, it stops processing all contacts, regardless of where they are in the journey. Use the **Start date and time** and **End date and time** settings on the **General** tab to set up the start and end dates, and use the **Time zone** setting to establish the time zone to use when interpreting these values.

### Choose your content settings

Content settings are sets of standard and required values that are available for use in marketing email messages. Each includes a subscription-center link, a forward-to-a-friend link, social-media links, your postal address, and other information that can be placed into the message as dynamic values by using the [assist-edit](dynamic-email-content.md#assist-edit) feature. You'll set up each customer journey to use a specific content-settings record, which means that all messages sent by that journey will use the same content settings. However, each journey can use a different content-settings record, which means that you can use an identical marketing-email design in two or more customer journeys, each specifying a different set of content settings. 

To choose the content settings used by a journey, go to its **General** tab and make a selection for the **Content settings** field.

For more information about how to create and configure content-settings records, see [Use content settings to set up repositories of standard and required values for email messages](dynamic-email-content.md#content-settings)

If you have more than one set of content settings, exactly one of them will be the default and will be applied automatically to each new customer journey that you create. For more information about how to establish the default content-settings record for new journeys, see [Configure default marketing settings](mkt-settings-default-marketing.md).

### Set up a recurring journey

Usually, a journey takes each contact through its pipeline exactly once. Even if you use several segments, and a given contact appears in more than one of them, each contact is processed at most once. However, you can also set up a recurring journey in which all contacts are reprocessed at regular intervals during the active period.

To set up a recurring journey:

1. Open your journey and go to the **General** tab.
1. Set **Is recurring** to **Yes**. This opens two additional settings here.
1. Set the **Recurrence interval** to the number of days each recurrence should last.
1. Set the **Recurrence count** to the maximum number of recurrences each contact can experience.

> [!NOTE]
> Your recurrence schedule must fit within your start and end dates, such that:  
**interval * count &le; end date &ndash; start date**.

> [!IMPORTANT]
> When the last iteration of a recurring journey is complete, the journey will change to a **Stopped** state. When the journey is stopped, it is assumed that the iteration schedule is completed. Attempting to restart the stopped customer journey will immediately result in the journey transitioning back to the stopped state.
>
> You can extend the customer journey after the last iteration of a recurring journey by increasing the **Iterations count** value. After you've increased the iterations count, the customer journey will go back to a **Live** state.
>
> To see the iterations that are already executed and executing, go to **Related** > **Customer Journey Iterations**. For each iteration, the **Created On** value marks the time that the iteration was started.

<a name="suppression-segment"></a>

### Add a suppression segment

A journey's suppression segment contains a list of contacts that the journey won't send any messages to, even if those contacts are also included among the segments explicitly targeted by the journey, and even if those contacts are already partly through the journey. 

You can use any existing segment as a suppression segment. To choose a suppression segment for your journey, open its **General** tab and then choose a segment in the **Suppression segment** lookup field.

## Go live to start running the journey and processing contacts

When you first create a new customer journey, and while you're working on it, the journey shows a **Status reason** of **Draft**. While it's still in draft, the journey is inactive and it won't try to send any messages or do any other processing. When everything's in place and you're ready to start running the journey, you publish it. This updates the journey's **Status reason** to **Live**, and as soon as the specified **Start Date** arrives, the journey will start processing all contacts in its target segment.

When you've finished designing your customer journey, do the following to verify and publish it:

1. Double-check the **Start Date** and **End Date** on the **General** tab. The customer journey won't do anything until the **Start Date** arrives and it will stop processing all contacts, no matter which tile they're on, as soon as the **End Date** arrives. Remember also that any contact who joins the target segment while a journey is running will also be processed by that journey, starting at the first tile.

2. Select **Check for Errors** in the command bar to verify your campaign setup and check it for errors. This step makes sure that all required marketing emails and pages are assigned and published, and also checks for other prerequisites and common errors. If problems are found, you'll see an error message with advice for how to fix it. Continue to check, fix reported errors, and check again until your journey passes the test.

3. Now you're ready to publish, so select **Go Live** in the command bar. Dynamics 365 Marketing runs the error check one last time. If your journey passes, it is published to the marketing services, which also host your published marketing email messages and marketing pages.

[!INCLUDE [cc-marketing-email-size](../includes/cc-marketing-email-size.md)]

## Gain insights by monitoring journey progress and results

As soon as your journey starts running, it will begin to generate and collect information about where your contacts are in their journey and how they've interacted with its various elements such as emails, pages, and events. Dynamics 365 Marketing provides a wealth of information, including analytics, KPIs, graphs, and more, to help you gain insights from your marketing results. More information: [Analyze results to gain insights from your marketing activities](insights.md)

## View milestones in the customer journey life cycle

Customer journeys pass through many states while you create, edit, and run them. You can now view a full history of these milestones for any customer journey. To see the milestone history, open any live or previously live journey, go to the **Designer** tab, and view the **Journey milestones** panel on the right side of the page.
 
![Journey events list](media/customer-journey-milestones.png "Journey events list")

### See also

[Customer journey tiles reference](customer-journey-tiles-reference.md)  
[Create a simple customer journey](create-simple-customer-journey.md)  
[Create an interactive customer journey](create-interactive-customer-journey.md)  
[Create an inbound customer journey](create-inbound-customer-journey.md)  
[Generate activities from a customer journey](generate-activities-from-customer-journey.md)  
[Working with segments](segmentation-lists-subscriptions.md)  
[Accessibility and keyboard shortcuts](designer-shortcuts.md)  
[Go live with publishable entities and track their status](go-live.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]