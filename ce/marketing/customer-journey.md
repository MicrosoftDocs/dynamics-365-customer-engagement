---
title: "Preview: Create a customer journey using the new canvas experience (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to create a customer journey using the new canvas experience for Dynamics 365 Marketing"
keywords: customer journey
ms.date: 09/30/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: reference
ms.assetid: 57e1c0f7-a12e-49ff-9110-0dcaae176855
author: alfergus
ms.author: alfergus
manager: shellyha
ms.reviewer:
topic-status:
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Early access: Create a customer journey using the new canvas experience

> [!IMPORTANT]
> Early access features are currently available only on opted-in instances. You can opt in for early access on any instance, but we recommend that you do so only on trial, test, or sandbox instances, which will give you a chance to learn the new functionality before it shows up on your production instances later this year.
>
> For instructions on how to opt in and enable early access, see [Opt in to early access updates](https://docs.microsoft.com/power-platform/admin/opt-in-early-access-updates). For more information about the 2020 release wave 2 schedule, and for answers to frequently asked questions about the early access program, see [2020 release wave 2 features available for early access](https://docs.microsoft.com/dynamics365-release-plan/2020wave2/features-ready-early-access).
>
> We encourage all customers to provide feedback related to early access features on the [Dynamics 365 Marketing Forum](https://community.dynamics.com/365/marketing/f/dynamics-365-for-marketing-forum), your Microsoft contact or partner, and/or through [Microsoft Support](https://docs.microsoft.com/power-platform/admin/get-help-support).

We've simplified the process of creating multistep campaigns by completely redesigning the customer journey canvas. An enhanced UI, improved preview capabilities, a new view of journey insights, and more options to adjust the canvas view result in a more intuitive and efficient user experience.

The new customer journey experience includes:

- A complete redesign of the canvas, making the experience of building customer journeys more intuitive. You no longer need to switch between the canvas and the toolbox while dragging elements onto the canvas. Now, you can build the whole journey directly on the canvas, using an in-place journey menu.
- The ability to customize the canvas to your preferences with horizontal and vertical layout options.
- Improved visual journey insights.
- Enhanced performance and reliability when building complex, multistep journeys.
- Simplified time-based journey actions. **Wait for** and **Wait until** tiles are now available.
- Negative journey paths, enabling follow-up events exclusively for recipients who didn’t meet a certain condition—for example, recipients who didn’t open an email and select a link.

## Journey tiles in the new designer

The following definitions explain how to work with each type of tile available for constructing your customer journeys.

### Audience

- **Segment**: A segment is a collection of contacts grouped according to a common attribute or explicit assignment. More information: [Working with segments](segmentation-lists-subscriptions.md)
- **Form submitted**: All new or existing contacts who submit the form will be sent along the customer journey. More information: [Create an inbound customer journey](create-inbound-customer-journey.md). You can also create an audience based on a submitted form by creating a segment comprised of people who submitted the form.
- **Record updated**: Use the record-updated tile to monitor all records belonging to a specific entity, and then find the contact associated with any of those records that gets created, deleted, or updated while the journey is running. All contacts found by this tile will be sent along the customer journey.

### Messages

The content that your customer journey delivers to contacts as they traverse the pipeline. Message tiles include email for now.

- **Send an email**: This tile sends a marketing email message to each contact who enters it.

### Branches

- **If/then**: This tile has replaced the **Trigger** tile. The If/then tile holds contacts either until a defined condition is true, or until a defined amount of time expires. The If/then tile splits the path. Contacts who fulfill the conditions in time will follow the true path. Contacts who haven't met the conditions when the time expires will follow the false path.

    > [!IMPORTANT]
    > To be able to define a condition, you need to first define at least one other tile in a journey. This is necessary so that its entity (or any of the entity’s dependencies) can be selected as a condition source.

- **Split**: This tile has replaced the **Splitter** and **Splitter-branch** tiles. The Split tile adds a fork to the customer journey pipeline, sending a random selection of contacts along each available path.

### Wait/delay

- **Wait for**: This tile has replaced the duration **Scheduler** tile. The Wait for tile holds contacts for an amount of time before sending them to the next tile in the journey. You could use this to insert a delay of, say, a week between sending an initial marketing email message and then sending a reminder.
- **Wait until**: This tile has replaced the date and time **Scheduler** tile. The Wait until tile holds contacts until a certain date is reached. For example, you could set the tile to wait until December 31 before sending the contacts to the next tile in the journey.

### Actions

- **Create lead**: The create-lead tile creates a new lead for each contact or account that enters the tile. It doesn't try to match any existing leads, so it always creates a new one. Each lead created will be linked either to the contact who entered the tile, or to the account that contact belongs to (the company or organization they work for).
- **Run workflow**: Use a Run workflow tile to invoke a [custom workflow](https://docs.microsoft.com/dynamics365/customerengagement/on-premises/customize/workflow-processes) at any point in the customer journey. You can use this tile to advance a process stage, create alerts, and more. Workflows are highly customizable. Many organizations work with internal or external consultants to optimize workflows for their own unique, internal business requirements.
- **LinkedIn campaign**: The LinkedIn campaign tile links each contact who passes through it to a specific LinkedIn campaign. Thus, this tile makes it possible for a subsequent trigger tile to react to submissions of any LinkedIn Lead Gen Forms that belong to that campaign on LinkedIn.

### Sales activities

- **Appointment, Phone call, Task**: We have split the old **Activity** tile into three separate tiles to add various types of sales activities more easily. These tiles are records of planned or completed real-world activities that relate to some other record in Dynamics 365. When a contact enters an Appointment, a Phone call, or a Task tile, the tile generates a new Dynamics 365 Marketing activity related to that contact (or the company or organization they work for). The contact then proceeds immediately to the next step in the customer journey.

### Custom tiles

- **Custom channel**: Custom channel tiles provide similar capabilities to the standard tiles described earlier (such as sending communication, tracking customer interactions, and adding triggers) but are created by partners and third-party developers to extend the marketing capabilities in Dynamics 365 Marketing. These custom tiles will appear in the designer if you have installed a partner-developed custom channel for customer journeys or have created and deployed your own custom channel for your Dynamics 365 Marketing instance.

  Custom channels use the existing extensibility infrastructure and tooling in Dynamics 365, such as custom entities, workflows, and plug-ins, which allow developers and partners to leverage their knowledge of Dynamics 365. More information: [Extend customer journeys using custom channels](https://docs.microsoft.com/dynamics365/marketing/developer/extend-customer-journeys-custom-channels)

### Legacy tiles

> [!IMPORTANT]
> The following legacy tiles will be phased out and removed at a future date. Each description details how to achieve the same results as the legacy tiles in the updated customer journey designer.

- **Event**: Event tiles are typically referenced in email tiles, where they represent a link to an event website that is included in the message's content. In the old designer, event tiles were used also to enable trigger tiles placed later in the pipeline to “know” about the event link and to react to contact interactions with the link (registered or attended). 

  In the new designer, the same can be achieved by adding a given event as a dependency to an email (in the properties of the email tile). <br>
    
- **Marketing form**: The marketing form tile represents an embedded or captured form hosted on an external website. In the old designer, this tile could be used as a nested tile under email tiles to represent a link to an external page that is included in the email message’s content (the external page had to include the captured or embedded marketing form represented by the tile). The marketing form tile could also be used to enable trigger tiles placed later in the pipeline to “know” about the external-page link and to react to contact interactions with the link. 

  In the new designer, the same can be achieved by adding a Marketing form entity as a dependency to an email (in the properties of the email tile). 

  In the old designer, the marketing form tile was also placed at the start of a journey to create an inbound campaign. When placed at the start of a journey, all new or existing contacts who submitted the form were sent on that journey. 
    
  With the new designer, this is no longer needed as the audience can be defined using a form, by selecting the form submitted as a source. Alternatively, an audience can be defined by using a segment of all the people who submitted a given form. 

- **Marketing page**: The marketing page tile represents a native marketing page designed in Dynamics 365 Marketing and running on a Dynamics 365 portal. In the old designer, this tile could be used as a nested tile under email tiles to represent a marketing page link that is included in the email message’s content. It could also be used to enable trigger tiles placed later in the pipeline to “know” about the marketing link and to react to contact interactions with it. 

  In the new designer, the same can be achieved by adding a Marketing page entity as a dependency to an email (in the properties of the email tile). 

  In the old designer, this tile was also placed at the start of a journey to create an inbound campaign. When placed at the start of a journey, all new or existing contacts who submitted the page were sent on the journey. 
  
  With the new designer, this is no longer needed because the audience can be defined with the form submitted as a source. Alternatively, an audience can be defined using a segment of all the people who submitted a given page.

> [!NOTE]
> The Marketing survey tile has been removed from the designer. Marketing surveys should instead be referenced in an email tile or used as a condition when defining a segment.

## Create a customer journey with email messaging

A simple customer journey can include just two steps: identifying the target segment and creating an activity that addresses the members of that segment. In the following procedure, you'll set up a simple customer journey that sends an email message to all the members of a target segment.

Before you start, you'll need:

- A segment containing the contacts you will send your email to. Your segment should include just one or two fictional contacts with valid email addresses that you can receive mail from, like the one you set up in [Create a dynamic segment](create-segment.md).
- A marketing email that is both valid and live. You should be able to use the message you designed and published in [Create a marketing email and go live](create-marketing-email.md).

To create a customer journey that executes a one-time email blast:

1. Go to **Marketing** > **Marketing Execution** > **Customer Journeys**. This takes you to a list of existing customer journeys. Select **New** on the command bar.

    > [!div class="mx-imgBorder"]
    > ![Select New in the command bar](media/customer-journey-new.png "Select New in the command bar")

1. The **New Customer Journey** page opens with the **Select a Customer Journey Template** dialog box shown. Each template provides a starting point for designing a particular type of customer journey. The template dialog box provides tools for searching, browsing, and previewing your template collection. Select **Skip** to start creating the journey from scratch.

    > [!div class="mx-imgBorder"]
    > ![Customer journey templates screen](media/customer-journey-templates.png "Customer journey templates screen")

1. Now you are looking at the customer journey designer. Here, you will assemble a pipeline that defines each step of the journey. Like all journeys, this one starts with the participants, who in this case are the people you specify as part of a market segment.

    > [!div class="mx-imgBorder"]
    > ![Customer journey select audience screen](media/customer-journey-audience.png "Customer journey select audience screen")

1. Select **Set audience** (or, alternatively, select **+**). The **Audience** properties pane will appear on the right side of the page. Leave the default settings there (for example, **Segment** selected as the audience source type). Select the segment that you want to target with your campaign in the segment lookup field.

    > [!div class="mx-imgBorder"]
    > ![Customer journey segment lookup](media/customer-journey-segment.png "Customer journey segment lookup")

1. After you select a segment, the first tile populates with the segment name and the **Audience** pane displays the segment properties.

    > [!div class="mx-imgBorder"]
    > ![Customer journey segment populate](media/customer-journey-audience-populate2.png "Customer journey segment populate")

    > [!TIP]
    > When your customer journey is live, all contacts start at the **Audience** tile (the initial step). Contacts move forward depending on the tile rules, similar to a board game. Some tiles hold on to contacts for a while, while other tiles complete an action immediately and send the contact to the next tile in the pipeline. Other tiles can split the path based on contact information or interactions. When the journey is live, you'll be able to see how many contacts are waiting at each tile, along with a few key results associated with the tile.
    >
    > In this example, you will add one more tile—an **Email** tile—which sends an email message to each contact who enters the tile.

1. Select **+** on the canvas, and then select **Send an email** from the contextual menu.

    > [!div class="mx-imgBorder"]
    > ![Customer journey send an email tile](media/customer-journey-email.png "Customer journey send an email tile")

1. Select the email tile on the canvas and select the email message that you want to send. You can use the sample email message you created earlier in [Create a marketing email and go live](create-marketing-email.md).

    > [!div class="mx-imgBorder"]
    > ![Customer journey select an email](media/customer-journey-select-email.png "Customer journey select an email")

1. Once the email is selected, the **Send an email** tile populates with the email name and the **Send an email** properties pane displays the segment preview and properties.

    > [!TIP]
    > All the segments and email messages that you reference in your customer journey must be live before you can go live with the customer journey itself.

1. Until now, you've been working in the **Designer** tab. Now go to the **General** tab, where you can name your journey and configure its run schedule.
    
    Make the following settings in the **General** tab:
    
    - **Name**: Enter a name for the customer journey that you can easily recognize later. This name is internal-only.
    - **Start date and time**: Enter the time when the journey should begin processing contacts. When you select the field, a suggested default time is provided.
    - **End date and time**: Enter the time at which the journey should stop processing contacts. All actions will stop at this time, even if some contacts are still in the middle of the journey. If you're just testing, allow a couple of weeks.
    - **Time zone**: Select your local time zone (if needed). The other dates and times on the page will be displayed relative to this zone.
    - **Content settings**: This should already be set to the default content settings record set for your instance. These settings affect the dynamic content of marketing emails sent by this journey (as mentioned in [Create a marketing email and go live](create-marketing-email.md)).

    > [!div class="mx-imgBorder"]
    > ![Customer journey General tab](media/customer-journey-general2.png "Customer journey General tab")

    > [!TIP]
    > While your journey is running, it will continue to process new contacts that join its segment, even if they join after the start date. This means that new contacts can join in at any time until the end date arrives.

1. On the command bar, select **Save** to save the work you've done so far.
1. To make sure your journey includes all required content and settings, select **Check for errors** in the command bar. Dynamics 365 Marketing examines the customer journey and then displays results. 

    If errors were found, you'll see a message at the top of the window and various indicators to show where the problems are. For example, if one of your tiles is misconfigured, you'll see an error icon in the relevant tile, and you can read details about the error by selecting the tile and opening its **Properties** tab. If you followed this procedure and your email message is live, your journey should pass the error check. If it doesn't, read the error message, fix the reported issue, and try again until it passes.
    
    > [!div class="mx-imgBorder"]
    > ![Customer journey error notification](media/customer-journey-error.png "Customer journey error notification")

1. Your journey is now ready to go. To start the journey, publish it by selecting **Go live** on the command bar.

    Dynamics 365 Marketing copies the journey to its email marketing service, which executes the journey by processing contacts, performing actions, and collecting results during the time it is set to run. The journey's **Status Reason** is updated to **Live**.

    > [!div class="mx-imgBorder"]
    > ![Customer journey Go live](media/customer-journey-go-live.png "Customer journey Go live")

1. If you have sent test messages to yourself, it might take several minutes for your messages to send, so allow some time for them to arrive in your inbox. After they do, open them and load the images. Then you can go back to Dynamics 365 Marketing and see how your journey is going. The **Designer** tab now shows information and results for each tile from your pipeline. Open the **Insights** tab to see detailed analytics.

    > [!TIP]
    > Many entities in Dynamics 365 Marketing provide an **Insights** tab for analyzing the results of your marketing initiatives. For example, try opening the email message you sent with this customer journey and check its **Insights** tab for even more information.

### See also

[Generate activities from a customer journey](generate-activities-from-customer-journey.md)  
[Create an interactive customer journey](create-interactive-customer-journey.md)  
[Use customer journeys to create automated campaigns](customer-journeys-create-automated-campaigns.md)  
[Customer journey tiles reference](customer-journey-tiles-reference.md)  
[Working with segments](segmentation-lists-subscriptions.md)
