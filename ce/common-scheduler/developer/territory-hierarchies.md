---
title: 
description:
ms.date: 04/30/2024
searchScope: 
  - Field Service
  - Project Service
ms.reviewer: mhart
ms.subservice: common-scheduler
ms.topic: conceptual
author: mkelleher-msft
ms.author: mkelleher
---

# Extend Universal Resource Scheduling to filter bookable resources by territory hierarchy

The article discusses how to extend Universal Resource Scheduling to filter bookable resources and consider the territory hierarchical relationship. As a result when searching with a territory constraint, the system finds bookable resources matching child service territories that relate to the constraint.

## Prerequisites

[Territory hierarchy](../../field-service/set-up-territories.md) must be configured to reflect the organization's service territory setup. 

## Extend the schedule board to filter by territory hierarchy

To filter resources on the schedule board and consider territory hierarchy, you need to update the **Filter layout** and the **Retrieve resources query**.

### Update filter layout

By default, the territory field lets you choose multiple territory values. To consider a hierarchy, the field must accept only one territory.

1. [Open the schedule board settings](../schedule-board-tab-settings.md#board-settings) and go to the **Other** section.

1. In the **Filter layout** section, create a new filter layout and name it.

1. Change the territory field configuration to disallow multiple values:

   `<control type="combo" source="entity" key="Territories" unspecified-key="UnspecifiedTerritory" label-id="ScheduleAssistant.West.Territories" entity="territory" multi="false"  />`

1. Change the filter layout to use the one you just created and save your changes.

### Update Retrieve resources queries
<!--continue here-->
In order to to get the territorries in the hierachy and to consider resources from Parent or child territories we need to modifiy the query 

To not lose the default configuration copy the previous retrieve resource query and create a new query for the retrieve resources 

Update the new query: 

OOB: 

 

        <!-- Territory join --> 

        <link-entity ufx:if="$input/Territories/bag | $input/UnspecifiedTerritory[. = 'true']" name="msdyn_resourceterritory" from="msdyn_resource" to="bookableresourceid" alias="territory" link-type="outer"> 

          <filter> 

            <condition attribute="statecode" operator="eq" value="0" /> 

            <condition attribute="msdyn_territory" operator="not-null" /> 

          </filter> 

        </link-entity> 

        <!-- Territory filter --> 

        <filter type="or"> 

          <condition ufx:if="$input/UnspecifiedTerritory[. = 'true']" entityname="territory" attribute="msdyn_territory" operator="null" /> 

          <condition ufx:if="$input/Territories/bag" entityname="territory" attribute="msdyn_territory" operator="in"> 

            <ufx:apply select="$input/Territories/bag"> 

              <value> 

                <ufx:value select="@ufx-id" /> 

              </value> 

            </ufx:apply> 

          </condition> 

        </filter> 

 

 

Modified: 

 

        <!-- Territory join --> 

        <link-entity  name="msdyn_resourceterritory" from="msdyn_resource" to="bookableresourceid"  link-type="outer"> 

        <link-entity ufx:if="$input/Territories" name="territory" alias="territory" link-type="inner" to="msdyn_territory" from="territoryid"> 

        <!-- Get the territory name --> 

        <attribute name="name" alias="territoryname" groupby="true" /> 

        <filter> 

           <condition attribute="territoryid" operator="not-null" /> 

        </filter> 

        </link-entity> 

        </link-entity> 

        <!-- Territory filter --> 

        <filter type="or" ufx:if="$input/Territories"> 

            <condition ufx:if="$input/UnspecifiedTerritory[. = 'true']" entityname="territory" attribute="territoryid" operator="null" /> 

            <condition  entityname="territory" attribute="territoryid" operator="eq-or-under"> 

                <ufx:value select="$input/Territories" attribute="value" /> 

            </condition> 

        </filter> 

 

The hierarchy relationship direction can be change choosing between “eq-or-under” or “eq-or-above” on <condition  entityname="territory" attribute="territoryid" operator="eq-or-under">. This way we will set the hierarch behavior from looking for resources from parent to child on the other way around. 

Make sure that the the new query is the one slected in Filter layout and select save 

 

 

 

Extend Schedule Assistant to filter by territory considering hierarchy.  

Using Schedule assistant we can retrieve the service territory from the requirement, so for schedule assistant we also must modify “Schedule assistant retrieve constraints query” as responsible to define resource filtering based on the requirement. 

[Note: Schedule Assistant configuration is only available on default configuration and not on custom tabs / views. This means that territory filtering will only be available when book button is used as only in this scenario, the default configuration will be used.} 

 

On Board settings: “<<tab/view name>>” Select Schedule types to expand and slect Work Order 

Select Edit defaults to make Schedule assistant configuration visible. 

A screenshot of a computer

Description automatically generated 

It is possible to reuse the previously created configuration and query selecting those on Schedule Assistant filter layout and Schedule assistant retrieve resources query.  

To not lose the default configuration, copy the previous Schedule assistant retrieve constraints query and create a new query for the Schedule assistant retrieve constraints 

OOB: 

 
<Territories ufx:select="lookup-to-list(Requirement/msdyn_territory)" /> 

 

Modified: 

 

   <Territories ufx:select="Requirement/msdyn_territory"/> 

 

This change allows us to continue to retrieve the territory from the requirement after we change from multi / list to single entry 

Make sure that the the new query is the one slected in Filter layout and select save 

 

 

 

Related resources 

You can use the following resources to learn more about Territories and extend Universal Resource Scheduling 

Configure Parent territory: Set up Sales territories | Microsoft Learn 

Extend Universal Resource Scheduling with Universal FetchXML Universal FetchXML to extend Universal Resource Scheduling | Microsoft Learn 

Customize the schedule board with a custom resource attribute Customize the schedule board with a custom resource attribute - Dynamics 365 Field Service | Microsoft Learn 

 
