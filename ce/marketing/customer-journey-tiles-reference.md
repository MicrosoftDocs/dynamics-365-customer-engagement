---
title: "Customer-journey tiles (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Details for how to use each tile that is available for assembling a customer journey pipeline for Dynamics 365 for Marketing"
keywords: "customer journey; tile; reference; pipeline"
ms.date: 04/01/2018
ms.service: dynamics-365-marketing
ms.topic: reference
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 57e1c0f7-a12e-49ff-9110-0dcaae176855
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
ms.custom: dyn365-marketing
---

# Customer journey tiles reference

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

The following tiles are available for constructing a customer journey.

## Content-type tiles

Content-type tiles represent the various types of content that your customer journey delivers to contacts as they traverse the pipeline. Content-type tiles include email, landing page, event, and survey tiles.

### Email

The email tile sends a marketing email message to each contact that enters it. It has the following settings, which you can set by using the **Properties** pane while an email tile is selected:

- **Name**: A local name for the tile. This name identifies the tile in the pipeline, but isn't used anywhere else.
- **Email**: Identify the marketing email message that the tile will send. Before you can publish your customer journey, all the marketing emails it references must also be finalized and published.
- **Description**: Add a description or other notes here (optional).

Your marketing email messages might contain special links to other [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] features such as marketing pages, event portals, or voice-of-the-customer surveys, and you can set up customer-journey trigger tiles that react to customer interactions regarding each or any of these specifically. But even though you've selected a marketing email message that includes elements such as these, the customer journey won't know about them unless you also add a child tile for each specific link that you want to trigger on. Add a landing-page, event, or survey tile as a child to an email tile to expose these elements and make them selectable in your trigger-tile configurations. (Triggers can also react to message opens and unspecified link clicks, but you don't need to do anything special to enable this.)

You can add a child tile to an email even if the associated message doesn't yet include the link represented by the child tile. This lets you plan your customer journey first and then finish your email designs later.

To add a child tile, expand the email tile if needed by clicking on the expand button in its bottom right corner, then drag a landing-page, event, or survey tile to the next open slot at the bottom of the stack. You must then configure the child tile to represent the same landing page, event, or survey that the email links to, and which you want to trigger on.

![Add a child to a parent tile](media/cj-add-child-tile.png "Add a child to a parent tile")

See the following sections for more information about working with the landing page, event, and survey tiles.

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Prepare marketing email messages](prepare-marketing-emails.md)

### Landing page

A landing page is any marketing page that is the destination of a link embedded in some other type of marketing message, such as an email or social media post. Landing page tiles can be children of marketing email tiles, where they represent a landing-page link that is included in the parent message's content. The most important reason to add a landing page tile is to enable trigger tiles placed later in the pipeline to "know" about the landing page link and to react to contact interactions with it. Triggers can react either as soon as a contact clicks on the link in an email, or only after a contact submits the form after clicking it in the email.

When you add a landing-page tile as a child of an email tile, you must take care to ensure that the marketing email message itself also includes a link to the same landing page (the system doesn't confirm this or modify the message when you add a child tile).

Landing page tiles provide the following settings in the **Properties** pane while selected:

- **Name**: A local name for the tile. This name identifies the tile in the pipeline, but isn't used anywhere else.
- **Marketing Page**: Identify the marketing page represented by the tile. Start typing a page name to select an existing page, or click on **New** to create a new one from here.
- **Description**: Add a description or other notes here (optional).

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Create and deploy marketing pages](create-deploy-marketing-pages.md)

### Event

Event tiles are typically children of marketing email tiles, where they represent a link to an event portal that is included in the parent message's content, but they can also be placed on their own. The most important reason to add an event tile is to enable trigger tiles placed later in the pipeline to "know" about the event link and to react to contact interactions with it (registered or attended). Triggers can react either as soon as a contact clicks on the link in an email, or only after a contact registers for or attends the event.

When you add an event tile as a child of an email tile, you must take care to ensure that the marketing email message itself also includes a link to the same event (the system doesn't confirm this or modify the message when you add a child tile).

Event tiles provide the following settings in the **Properties** pane while selected:

- **Name**: A local name for the tile. This name identifies the tile in the pipeline, but isn't used anywhere else.
- **Event**: Identify the event record represented by the tile. Start typing an event name to select an existing event, or click on **New** to create a new one from here.
- **Description**: Add a description or other notes here (optional).

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Event planning and management in Dynamics 365](event-management.md)

### Survey

Survey tiles are typically children of marketing email tiles, where they represent a link to an online survey that is included in the parent message's content. The most important reason to add a survey tile is to enable trigger tiles placed later in the pipeline to "know" about the survey link and to react to contact interactions with it. Triggers can react either as soon as a contact clicks on the link in an email, or only after a contact submits the survey.

When you add a survey tile as a child of an email tile, you must take care to ensure that the marketing email message itself also includes a link to the same survey (the system doesn't confirm this or modify the message when you add a child tile).

Survey tiles provide the following settings in the **Properties** pane while selected:

- **Name**: A local name for the tile. This name identifies the tile in the pipeline, but isn't used anywhere else.
- **Survey**: Identify the voice-of-the-customer record represented by the tile.
- **Description**: Add a description or other notes here (optional).

[!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Create and run online surveys](surveys.md)

## Action tiles

Action tiles launch workflows or create new action records within [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. You'd typically use these to generate to-do assignments for internal personnel to follow-up on things that happen during a customer journey.

### Activity

An *activity* is a record of a planned or completed real-world activity, such as an appointment, task, or phone call, that relates to some other record in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. Most forms in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] include an activity wall that shows all the activities that various users planned or completed in relation to that record, such as phone conversations with a specific contact, or meetings related to planning a particular event. Records for planned activities can function as a to-do list for the users they are assigned to, and records for completed acStivities can contain details about what happened or what the outcome was.

Activity tiles are stand-alone, so they never have any parent or child tiles.

When a contact enters an activity tile, the tile generates a new [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] activity related to that contact, and then the contact proceeds immediately to the next step in their customer journey.

Activity tiles provide the following settings in the **Properties** pane while selected:

- **Name**: A local name for the tile. This name identifies the tile in the pipeline, but isn't used anywhere else.
- **Activity Type**: The type of activity (such as appointment, task, or phone call) the tile creates.
- **Activity Template**: The template to use when creating the activity. The templates defines which type activity it is, who it should be assigned to, and other details. You can choose an existing template or create a new one from here, but you can only assign or create templates that have the same **Activity Type** as the tile. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Create activity marketing templates for activity tiles](customer-journeys-create-automated-campaigns.md#create-activity-marketing-templates-for-activity-tiles)
- **Properties**: After you've selected a template, a summary of its settings is shown here.
- **Assigned To:** The tile assigns all of the activities it generates to the [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] user identified here.
- **Description**: Add a description or other notes here (optional).

### Invoke workflow

Use a workflow tile to invoke a custom workflow at any point in the customer journey. You can use them to advance a process stage, create alerts, and more. Workflows are highly customizable, and many organizations work with internal or external consultants to optimize them for their own unique, internal business requirements.

Workflow tiles are stand-alone, so they never have any parent or child tiles.

Workflow tiles provide the following settings in the **Properties** pane while selected:

- **Name**: A local name for the tile. This name identifies the tile in the pipeline, but isn't used anywhere else.
- **Invoke Workflow**: Choose an existing workflow to be invoked by the tile.
- **Description**: Add a description or other notes here (optional).

## Target tiles

Target tiles establish the segment of contacts that will be targeted by your customer journey.

<a name="segment"></a>

### Segment

A segment is a collection of contacts grouped according to some common attribute or explicit assignment. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Market segmentation, marketing lists, and subscription lists](segmentation-lists-subscriptions.md)

Usually, each of your customer journeys starts with a segment tile, which establishes the collection of contacts who you'll be working with for that journey. When your customer journey starts running, it immediately processes all the contacts found in its target segments at that time. As time goes on, any new contacts that join the target segments will also start their journey here for as long as the customer journey is active.

Each segment tile is always either the parent or child of another segment tile, so at minimum you'll have a parent segment with a single child segment. The parent tile identifies it self as a _segment group_; it displays a name for the group and shows information about the total number of contacts it includes, and it establishes the logic for combining its various child tiles (intersection or union). Each child tile identifies an actual segment configured in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)].

![A segment tile with two child segments](media/cj-segment-stack.png "A segment tile with two child segments")

The previous image shows a segment stack built with two child segments. The population of the resulting target segment, which is what will be processed by the customer journey, depends on the logic established by the parent segment tile:

- When the parent segment is set to use *union* logic, any contact that is on at least one of the child segments will be included in the customer journey, but contacts that appear on more than one child segment will still be processed just once.
- When the parent segment is set to use *intersection* logic, then only contacts that appear on *all* child segments will be targeted, so customers that appear on just one of the lists will be ignored.

### Record update

The record-update tile identifies a set of contact records that have been updated since the journey started running, and then adds them to the journey starting at the location of the record-update tile. Its function is otherwise similar to a segment tile in that it adds contacts to the journey.

Record-update tiles are stand-alone, so they never have any parent or child tiles.

Record-update tiles provide the following settings in the **Properties** pane while selected:

- **Name**: A local name for the tile. This name identifies the tile in the pipeline, but isn't used anywhere else.
- **Entity Logical Name**: Choose which entity to monitor for updates. Usually, you'll chose "Contact".
- **Contact Field Name**: Choose a field from your selected entity to monitor for updates.
- **Trigger Types**: Choose which type of field change to look for (create, delete, or update).
- **Description**: Add a description or other notes here (optional).

## Flow-control tiles

Flow-control tiles create a pause or a branch in your pipeline, where contacts will go down just one of several available paths, depending on their interaction record or demographic data.

### Scheduler

The scheduler tile holds contacts for some amount of time before sending them on to the next tile in their journey. You could use this to insert a delay of, say, a week between sending an initial marketing email message and then sending a reminder. You can set the schedule using a relative time (such as: wait 7 days) or an absolute time (such as: wait until May 21, 2018).

Scheduler tiles are stand-alone, so they never have any parent or child tiles.

Scheduler tiles provide the following settings in the **Properties** pane while selected:

- **Name**: A local name for the tile. This name identifies the tile in the pipeline, but isn't used anywhere else.
- **Type**: Sets whether to use a relative or absolute schedule. Set this to **Duration** to set a relative time (such as wait 7 days) or to **Date & Time** to choose a specific date.
- **Duration**: This setting is only shown when **Type** is set to **Duration**. Enter an integer in the field here to define the number of days to wait, starting from the day a contact first enters the tile. Use the links here to choose a **Simple** duration, which will wait the exact number of days you specify, or an **Advanced** duration, which enables you to define a restriction window (see below).
- **Date & Time**: This setting is only shown when **Type** is set to **Date & Time**. Use the fields here to define the specific date, hour, and minute at which contacts waiting here will be released (regardless of when they arrived). Use the links here to choose a **Simple** schedule, which will use the exact date and time you specify, or an **Advanced** schedule, which enables you to define a restriction window (see below). Note the time zone information shown at the bottom of the **Properties** tab.
- **Restriction Window**: This setting is available for both **Duration** and **Date & Time** schedulers when they are set to **Advanced**. It establishes rules about which day or the week and/or time of day contacts will be released by the scheduler. To open it, click on the **Advanced** link in the **Duration** or **Date & Time** section. Use these settings to restrict the set of week days and/or times when contacts will first be released by the scheduler. This might result in a slightly longer delay. For example, you might set the scheduler to hold contacts for at least 7 days, but then release them on the first Monday, Wednesday, or Friday afternoon after that.
- **Description**: Add a description or other notes here (optional).

### Trigger

Trigger tiles hold contacts until some condition is true, or until a defined amount of time expires. The trigger splits the path, so contacts that fulfil the trigger conditions in time will go down the *true* path, but contacts that still haven't met the condition when time is us will go down the *false* path.

A typical use of this is to set up an email tile followed by a trigger tile that holds each contact for 7 days, or until he or she opens the message. As soon as a contact opens the message, the trigger sends that contact down the *true* path, which might include tiles designed for contacts that have shown an interest in your messages. However, if the time limit passes and the contact still has not opened the message, then the trigger will send that contact down the *false* path, which might send the original message again, just to make sure.

A wide range of trigger logic is available, and you can combine several rules into a complex logical expression. Some specialized trigger rules are even possible, such as reactions for specific landing page submissions, survey submissions or event registrations, but for these to work, the relevant survey, landing page, or event must be available to the trigger. So, to trigger on an email message, that message must be part of the current customer journey; and to trigger on a click or submission of a survey delivered by that email, that email tile must also have a child tile that links to the appropriate survey setup. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Email](#email).

Trigger tiles are stand-alone, so they never have any parent or child tiles.

When you add a trigger to your pipeline, it immediately creates a fork, with the true path marked with a check and leaving the right edge of the tile, and the false path marked with an X and leaving the bottom edge of the tile.

![A new trigger tile](media/cj-trigger-tile.png "A new trigger tile")

Trigger tiles provide the following settings in the **Properties** pane while selected:

- **Name**: A local name for the tile. This name identifies the tile in the pipeline, but isn't used anywhere else.
- **Timeout in**: Set the maximum amount of time that the trigger should hold a contact before sending it down the false path, provided the true condition isn't met during that time. Contacts are sent down the true path as soon as the condition is met. Use the field and drop-down list here to establish that amount of time to wait.
- **Set Rules**: All triggers must have at least one rule, so new ones start with a rule. You can add more rules by clicking on the **+ New** button here. Rules are combined using an AND operator, which means that if you define more than one, then all of the rules must evaluate to true before a contact is sent down the true path.
- **Rule &lt;n&gt;**: Each rule that you add creates a numbered **Rule** block. Each rule must have a **Source**, which identities the source of a value to test, and a **Condition**, which defines the condition that the found value must fulfil. The **Source** drop-down list shows all the sources that are currently available to the trigger tile; if you don't find a source you are looking for, then you might need to add a tile or child tile to make that source available.
- **Description**: Add a description or other notes here (optional).

### Splitter and splitter-branch tiles

Splitter tiles add a fork to the customer journey pipeline, sending a random selection of contacts down each available path.

You'll always use a splitter tile together with at least two splitter-branch tiles. The splitter tile initiates the split and establishes the basis for dividing the contacts (by percentage or absolute value), while each splitter-branch tile establishes the specific portion or number of contacts travelling down the path it controls. The bottom splitter-branch tile always implements a "remaining" rule, which applies to all contacts that don't fulfil any of the other available rules.

Splitter and splitter-branch tiles are stand-alone, so they never have any parent or child tiles.

When you add a splitter to your pipeline, it immediately creates a fork and adds a new "remaining" splitter-branch tile at the bottom path.

![A new splitter tile](media/cj-splitter-tile.png "A new splitter tile")

On adding a splitter tile:

1. Configure the splitter first to establish its "split-by" parameter (by percentage or absolute value).

1. Add at least one splitter-rule tile in the empty spot provided.

1. If needed, add more paths by dragging additional splitter-rule tiles between the top and bottom splitter-rule tiles.

1. Define the portion of contacts to be sent down each splitter branch.

Splitter tiles provide the following settings in the **Properties** pane while selected:

- **Name**: A local name for the tile. This name identifies the tile in the pipeline, but isn't used anywhere else.
- **Split By**: Choose how to define the portion of contacts sent down each branch. Choose **Percentage** to define each branch by a percentage of total contacts. Choose **Value** to define each branch using absolute values.
- **Description**: Add a description or other notes here (optional).

Splitter-branch tiles provide the following settings in the **Properties** pane while selected:

- **Name**: A local name for the tile. This name identifies the tile in the pipeline, but isn't used anywhere else.
- **Percentage** or **Value**: When the preceding splitter tile is set to split by percentage, set the percentage of contacts that should be sent down this branch. When the preceding splitter tile is set to split by value, enter the total number of contacts that should go down that branch.
- **Description**: Add a description or other notes here (optional).

## Custom content tiles

Custom content tiles provide similar capabilities as the standard tiles described earlier (such as sending communication, tracking customer interactions, and adding triggers) but are created by partners and third-party developers to extend the marketing capabilities in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]. These custom tiles will appear in the designer if you have installed a partner-developed custom channel for customer journeys or have created and deployed your own custom channel for your [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] instance. 

Custom channels take advantage of the existing extensibility infrastructure and tooling in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], such as custom entities, workflows, and plug-ins, which allow developers and partners to leverage their knowledge of [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. [!INCLUDE[proc-more-information](../includes/proc-more-information.md)]  [Extend customer journeys using custom channels](developer/extend-customer-journeys-custom-channels.md)

### See also

[Use customer journeys to create automated campaigns](customer-journeys-create-automated-campaigns.md)  
[Create a simple customer journey](create-simple-customer-journey.md)  
[Create an interactive customer journey](create-interactive-customer-journey.md)  
[Create an inbound customer journey](create-inbound-customer-journey.md)  
[Generate activities from a customer journey](generate-activities-from-customer-journey.md)  
