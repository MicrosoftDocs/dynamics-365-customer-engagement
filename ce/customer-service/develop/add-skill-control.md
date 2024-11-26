---
title: Skill control for routed records
description: Learn how to add a skill control on forms to view skills of any record that's routed through unified routing.
ms.date: 04/02/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.custom: 
  - dyn365-customerservice
  - bap-template
search.audienceType:
  - admin
  - customizer
---

# Add a skill control for routed records

Dynamics 365 provides a custom control that you can embed in your forms to view the skills of any routed record. To display the skill control for the routed record in the Customer Service workspace or Omnichannel for Customer Service (deprecated) app, add the control to the multisession form.

## Prerequisites

- To add the skill control, you must have the System Administrator or System Customizer security role, or equivalent permissions. For more information about your security role, go to [View your user profile](/power-apps/user/view-your-user-profile).
- To make sure that the skill control is loaded and displayed for the routed records, you must [allow access to these websites](../implement/system-requirements-omnichannel.md#allow-access-to-websites).
- [Omnichannel for Customer Service is provisioned](/dynamics365/contact-center/implement/provision-channels#set-up-channels).
- [Unified routing is enabled](../administer/provision-unified-routing.md).
- For the skills to appear in the skill control, you must [set up unified routing](../administer/set-up-routing-process.md).

## Add a skill control

In the following example, to add a skill control named **Skills** to the **Case for Interactive experience** form:

1. In Power Apps, select the required environment, and then select the solution that you want to customize.
1. Go to **Tables**, and select **Case** > **Forms**.
1. Select the **Case for Interactive experience** form.
1. Select Component, and on the Components site map, drag and drop a **1-Column section** on to the form. 
1. Select the section and in the right pane, enter the properties, such as the label.
1. In the site map, under Table columns, select **New table column**, and do the following steps in the right pane:
    1. On the **Properties** tab, enter the details under **Display options**.
    1. Expand **Components**, and select **Component**.
    1. In **Add component**, select Get more components. 
    1. Search **CC_OCRoutedEtnRelatedRecordsControl**, select **Components** and then select **Add**. The component is added to the list.
    1. Select the component again.
    1. To filter the skills based on the selected queue, on the **Add CC_OCRoutedEtnRelatedRecordsControl** pane, in the Static value field for **CC_FetchXML** or **CC_skillFilter_FetchXml**, enter a fetch XML that you have defined to curate the relevant set of skills that match the queue requirements. You can use the [Sample Fetch XML](#sample-fetch-xml) listed in this article.

1. Select **Done** and then save and publish the solution.

At runtime, your agents will be able to view the skill control on all routed case records in Customer Service Hub. They can also update the skills required for the routed records in real time. 

Though we don't recommend setting up parameters for the skill control, if you want to manually enter the logical collection name or the relationship name of the record, you can use the following OData queries to get the information.

- **Logical collection name**: Run the following OData query and enter the same in the **Value** field of the **CC_OCRoutedEntityName_value** property.

    `GET [Organization_URI]/api/data/v9.1/EntityDefinitions(LogicalName='{EntityLogicalName}')?$select=LogicalCollectionName,LogicalName`

- **Relationship name**: Run any of the following OData queries for one-to-many, many-to-one, or many-to-many relationships, and enter the same in the **Value** field of the **CC_OCRoutedEntityRelationshipName_value** property.

    `GET [Organization_URI]/api/data/v9.1/EntityDefinitions(LogicalName='incident')/OneToManyRelationships`

    `GET [Organization_URI]/api/data/v9.1/EntityDefinitions(LogicalName='incident')/ManyToOneRelationships`

    `GET [Organization_URI]/api/data/v9.1/EntityDefinitions(LogicalName=%27incident%27)/ManyToManyRelationships`

### Sample Fetch XML

```Fetch XML
<fetch version="1.0" output-format="xml-platform" mapping="logical" distinct="true">
	<entity name="characteristic">
		<attribute name="name" />
		<order attribute="name" descending="false" />
		<link-entity name="sc_characteristic_queue" from="characteristicid" to="characteristicid" visible="false" intersect="true">
			<link-entity name="queue" from="queueid" to="queueid" alias="am">
				<link-entity name="queueitem" from="queueid" to="queueid" link-type="inner" alias="an">
					<filter type="and">
						<condition attribute='objectid' operator='eq' value='eq_contextEntityId' />
					</filter>
				</link-entity>
			</link-entity>
		</link-entity>
	</entity>
</fetch>
```
### Related information

[Overview of unified routing](../administer/overview-unified-routing.md)  
[Set up record routing](../administer/set-up-record-routing.md)  
[Set up unified routing](../administer/set-up-routing-process.md)  
[Query table definitions using the Web API](/powerapps/developer/data-platform/webapi/query-metadata-web-api)  
[Add, configure, move, or delete components on a form](/powerapps/maker/model-driven-apps/add-move-configure-or-delete-components-on-form)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
