---
title: "FAQ for Sales business process flows (Dynamics 365 Sales) | MicrosoftDocs"
description: "Find answers to the frequently asked questions related to the Sales business process flows in Dynamics 365 Sales."
ms.date: 03/17/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---
<!--Change to the H1 is suggested because the Writing Style Guide seems to prefer "FAQ" (it says that it's more recognizable than the spelled-out version), but I see that "Frequently asked questions" is also used plenty of times in our content set. No hyphen in the spelled-out version, via Writing Style Guide.-->
# FAQ for Sales business process flows

Find answers to the frequently asked questions related to the Sales business process flows in Dynamics 365 Sales.<!--Do you expect to add other H2 headings in the future, or is this probably the sum total of questions you expect about Sales business process flows? If these questions are only going to be about the Sales pipeline chart and its phases, I recommend changing the H1 to "FAQ for the Sales Pipeline chart and pipeline phases," remove the H2 entirely, and promote the questions to H2s.-->

## Sales pipeline chart and pipeline phases
<!--None of this background information from line 20 to 37 belongs in a FAQ. It's just not discoverable - -no one would think to look here for it. It's great information, but it needs to be added to a relevant topic - or split off into its own topic entirely - and then linked to from a brief introduction here.-->
<!--BEGIN EXCERPT THAT SHOULD BE A SEPARATE TOPIC-->
Sales reps or managers use the out-of-the-box Sales Pipeline chart to visualize the revenue for an opportunity based on each pipeline phase. The following image shows a sample Sales Pipeline chart with pipeline phases such as 1-Qualify, 2-Develop, and so on. 

![Sales Pipeline chart](media/sales-pipeline-chart.png "Sales Pipeline chart")

The pipeline phase of an opportunity is based on the stage of the business process flow that it's currently in. When an opportunity moves through the stages of its business process flow, the pipeline phase is set to a value in the form of _{StageCategoryIndex} - {CategoryName}_.

To understand how each of the pipeline phases are named, go to the **Settings** area for the opportunity and open the business process flow definition associated with the opportunity record. 
 
There are four stages in the out-of-the-box Opportunity Sales Process flow. Each stage is mapped to a unique category, as highlighted in the **Properties** section of the image below. You can customize the business process flow definition by adding or removing stages, and you can also change the name that's displayed for each stage. The value of the pipeline phase attribute is based on the category of the stage and isn't affected by any change you make to the display name. 

![Opportunity Sales Process definition](media/opportunity-sales-process-definition.png "Opportunity Sales Process definition")
 
The category values used for each business process stage are defined in a global option set named **Stage Category**. When an opportunity moves from the **Qualify** to **Develop** stage of the Opportunity Sales Process flow, the metadata for the category of the new stage (**Develop**, in this example) is read. Because the order of the **Develop** stage in our example<!--edit okay?--> is **2**, the pipeline phase of the opportunity will be set to **2-Develop**.

![Stage Category option set](media/stage-category.png "Stage Category option set")

The label for the pipeline phase of an opportunity consists of the category order (index) of the associated stage followed by the name of the category.<!--Edit okay? I thought this was a bit confusing.--> In this way, pipeline phases are arranged in a sequence that matches the order of the associated category options in the **Stage Category** option set metadata. If you have a business need to introduce a new stage in the flow&mdash;for example, you want the stage **Negotiation** to appear between the **Propose** and **Close** stages&mdash;you must add a new category option named **Negotiation** in the **Stage Category** option set, and ensure that it's positioned between **Propose** and **Close**. 
<!--END EXCERPT THAT SHOULD BE A SEPARATE TOPIC.-->

### Why do I see multiple pipeline phases with different sequences, such as 6-Close and 7-Close?

This can happen if you've changed the sequence of a stage category option (for example, you changed **Close** from 6 to 7). Existing opportunities that moved to the **Close** stage before you made this change will continue to show the same pipeline phase value that was set when they moved to the **Close** stage. However, opportunities that move to the **Close** stage after you made this change will use the new sequence for the **Close** stage. You can reset the values for older opportunities either by changing the stage of the business process flow to some other stage and then bringing it back to the **Close** stage, or by updating the **stepname** attribute of the opportunity programmatically. 

### Why do I see pipeline phase values from multiple business process flow definitions?

This is to be expected if you use multiple business process flow definitions for the Opportunity entity. The out-of-the-box pipeline phase attribute is set on every stage change in the business process flow of the **Opportunity** record, irrespective of how many business process flows are associated with that record. If you have multiple business process flows<!--Is this what "In these cases" meant here?-->, consider adding a custom field to the Opportunity Sales Process<!--Is this where you need to add the custom field, or do you add the custom field to those other business process flows that you're running on the opportunity?--> and setting its value programmatically<!--I assume this is what "via SDK" means? Can this be a link to the relevant topic in the SDK?--> for the stage changes you require in the business process flow for the opportunity. 

### Why is the sales pipeline chart ordering displayed differently in the Unified Interface vs. the legacy web client?

The legacy web client displays the chart by using the value of the associated category option, whereas<!--via Writing Style Guide--> in the Unified Interface the stages are displayed alphabetically. Because the pipeline phases are prefixed with the order defined in the **Stage category** option set, they're displayed according to the category option sequence (1, 2, and so on).<!--Suggested.-->
