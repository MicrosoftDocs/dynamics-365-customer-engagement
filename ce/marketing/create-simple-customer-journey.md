---
title: "Create a simple customer journey (Dynamics 365 for Marketing) | Microsoft Docs"
description: "A tutorial for how to set up a customer journey that implements a simple email blast in Dynamics 365 for Marketing"
keywords: "tutorial; customer journey; send email; email blast"
ms.date: 12/15/2017
ms.service: crm-online
ms.topic: get-started-article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 45c4c442-2662-41a0-83c9-8e3149ed71ec
author: kamaybac
ms.author: kamaybac
robots: noindex,nofollow
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Create a simple customer journey with email messaging

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

[!INCLUDE[cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

<iframe width="560" height="315" src="https://go.microsoft.com/fwlink/p/?linkid=863167" frameborder="0" allowfullscreen></iframe>

As you engage potential customers, they start by discovering your product, evaluate whether it meets their needs, look for a good offer, and finally make a purchase. We call this process the *customer journey*. Use [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] customer journeys to create a model that helps you guide the members of a selected marketing segment through this process by using automated messaging, activity generation, interactive decision points, and more.

A simple customer journey can include just two steps: identifying the target segment and creating an activity that addresses the members of that segment. In the following procedure, you'll set up a simple customer journey that sends an email message to all the members of a target segment.

Before you start, you'll need:
- A segment containing the contacts you will send your email to. Your segment should include just one or two fictional contacts with valid email addresses that you can receive mail from, like the one you set up in [Create a dynamic segment](create-segment.md).
- A marketing email that is both valid and live. You should be able to use the message you designed and published in [Create a marketing email and go live](create-marketing-email.md).

To create a customer journey that executes a one-time email blast:

1. Go to **Marketing** &gt; **Marketing Execution** &gt; **Customer Journeys**. This takes you to a list of existing customer journeys.  
    ![Location of the new-journey button](media/new-journey-button-location.png "Location of the New button to create a journey")

    On the command bar, select **New**.

1. The **New Customer Journey** page opens with the **Select a Customer Journey Template** dialog box shown. Each template provides a starting point for designing a particular type of customer journey. The template dialog box provides tools for searching, browsing, and previewing your template collection.  
    ![The customer journey template dialog](media/journey-template-dialog.png "The customer journey template dialog box")

    Select **Blank template**, and then choose **Select**. The dialog box closes, and your selected template is copied to your new journey.

1. Now you are looking at the customer journey designer, where you will assemble a pipeline that defines each step of the journey.
    ![Add a segment to the customer journey](media/journey-add-segment.png "Add a segment to the customer journey")

    Like all journeys, this one starts with the participants, who in this case are the people you specify as part of a market segment. Drag a **Segment Group** tile from the **Toolbox** tab onto the first position of the pipeline.

1. Select the expand button at the lower-right corner of your new **Segment Group** tile to view the member segments of this group. Right now, there's just one, so select it.  
    ![Expand the segment tile to view its child tiles](media/journey-segment-expand.png "Expand the segment tile to view its child tiles")

1. With the child segment still selected, open the **Properties** tab to the right of the canvas.
    ![Assign a segment to the segment tile](media/journey-segment-props.png "Assign a segment to the segment tile")

    The **Properties** tab provides settings that apply to the selected tile. Set the **Segment** to the name of the segment that you want to target with your campaign.

    > [!TIP]
    > When your customer journey is running, all contacts start at the **Segment Group** block, and then step one block forward and do whatever it says there, and so on down the pipeline—like in a simple board game. Some blocks hold on to contacts for awhile, while others do something immediately and then send the contact on to the next block in the pipeline. Other blocks can split the path based on contact information or interactions. At runtime, you'll be able to see how many contacts are waiting at each block, along with a few key results associated with the block. In this simple example, you're going to add just one more block—an **Email** block—which sends an email message to each contact who enters the block.

1. Go back to the **Toolbox** tab and drag an **Email** block to the space immediately to the right of the **Segment Group** block.
    ![Add an email tile to the customer journey](media/journey-add-email.png "Add an email tile to the customer journey")

1. With the new **Email** block still selected, open the **Properties** tab again.
    ![Assign an email message to the email tile](media/journey-email-properties.png "Assign an email message to the email tile")  

    Set the **Marketing Email Message** to the name of the message that you want to send, such as the sample email message you created earlier in [Create a marketing email and go live](create-marketing-email.md).

    > [!TIP]
    > All the segments and email messages that you reference in your customer journey must be live before you can go live with the customer journey itself.

1. Until now, you've been working on the **Designer** tab. Now go to the **General** tab, where you can name your journey and configure its run schedule.  
    ![Customer Journey general settings](media/journey-general-settings.png "Customer journey general settings")

    Make the following settings here:
    - **Name**: Enter a name for the customer journey that you can easily recognize later. This name is internal-only.
    - **Time Zone**: Select your local time zone (if needed). The other dates and times on the page will be displayed relative to this zone.
    - **Start Date Time**: Enter the time when the journey should begin processing contacts. When you select the field, a suggested default time is provided.
    - **End Date Time**: Enter the time at which the journey should stop processing contacts. All actions will stop at this time, even if some contacts are still in the middle of the journey. If you're just testing, allow a couple of weeks.
    - **Content Settings**: This should already be set to your site's default Content Settings record. These settings affect the dynamic content of marketing emails sent by this journey (as mentioned in [Create a marketing email and go live](create-marketing-email.md)).

    > [!TIP]
    > While your journey is running, it will continue to process new contacts that join its segment, even if they join after the start date. This means that new contacts can join in at any time until the end date arrives.

1. On the command bar, select **Save** to save the work you've done so far.  
    ![Location of the save button in the command bar](media/journey-save-button-location.png "Location of the Save button in the command bar")

    > [!TIP]
    > The **Save** button might not always be present on the command bar, especially after you've saved the journey once. If you don't see it there, look for the smaller **Save** button in the lower-right corner of page, and select it there to save your work.
    > 
    > ![Location of the save button in the footer](media/journey-save-button-location-footer.png "Location of the Save button in the footer")

1. To make sure your journey includes all required content and settings, select **Check for Errors** in the command bar. [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] checks it and then displays results in the notification bar. Expand the notification bar to read the results.
    ![Check for errors button and  results](media/journey-check-for-errors.png "Check for Errors button and  results")

    If you followed this procedure and your email message is live, your journey should pass the error check. If it doesn't, read the error message, fix the reported issue, and try again until it passes.

1. Your journey is now ready to go. To start it running, publish it by selecting **Go Live** on the command bar.
    ![Location of the Go Live button](media/journey-go-live-button-location.png "Location of the Go Live button")

    [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] copies the journey to its email marketing service, which executes the journey by processing contacts, performing actions, and collecting results during the time it is set to run. The journey's **Status Reason** is updated to **Live**.

1. It might take a few hours for your messages to get sent, so allow some time for them to arrive in your inbox. After they do, open them and load the images. Then you can go back to [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] and see how your journey is going. Open your customer journey in [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] and switch to the **[!INCLUDE[pn-insights](../includes/pn-insights.md)]** view by using the drop-down list above the journey-name headline.
    ![Location of the view selector](media/journey-view-selector.png "Location of the view selector")

    From here, use the **Designer** tab to see information and results for each tile from your pipeline. Open the **Dashboard** tab to see detailed analytics.

    > [!TIP]
    > Many entities in [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] provide an **[!INCLUDE[pn-insights](../includes/pn-insights.md)]** view for analyzing the results of your marketing initiatives, including marketing emails. Try opening the record for the email message you sent with this customer journey and check its **[!INCLUDE[pn-insights](../includes/pn-insights.md)]** view for even more information.

### See also

[Use suppression segments to respect unsubscribe requests](suppression-segments.md)  
[Generate activities from a customer journey](generate-activities-from-customer-journey.md)  
[Create an interactive customer journey](create-interactive-customer-journey.md)  
[Use customer journeys to create automated campaigns](customer-journeys-create-automated-campaigns.md)  
[Customer journey tiles reference](customer-journey-tiles-reference.md)  
[Segmentation, lists, and subscriptions](segmentation-lists-subscriptions.md)