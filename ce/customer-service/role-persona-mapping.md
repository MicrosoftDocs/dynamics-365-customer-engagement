---
title: "Roles and personas | MicrosoftDocs"
description: "Get information about how custom security roles can be mapped to personas in Customer Service and Omnichannel for Customer Service."
ms.date: 04/04/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
---

# Manage personas and custom security roles in Customer Service

## Introduction

You can map security roles to personas to define user permissions for unified routing. Persona mapping gives your organization the option to add custom security roles alongside existing security roles in Customer Service and Omnichannel for Customer Service. The admin, supervisor, and agent personas are user archetypes that security roles can be mapped to. By mapping custom security roles to these personas, you can fine-tune data access and security across users and business units.

You can create and assign custom security roles in the Microsoft Dynamics 365 admin center. Persona mapping can be found in the Omnichannel admin center or Customer Service Hub in the **User attributes** section. For the custom security roles to be functional, perform the following steps:

1. Create custom security roles.
2. Map roles to personas.
3. Enable access to applications.
4. Enable access to forms and dashboards.

## Personas for unified routing

### Admin

The admin persona can set up end-to-end workflows to handle customer interactions using unified routing and can perform the following tasks:

- Create and manage classification and assignment rules for work items based on business rules.
- Create and maintain capacity profiles and schedules based on office hours.
- Configure basic and advanced routing for all work items.
- Create and maintain agent skills for efficient skill-based routing of work items.
- Manage users and their permissions by mapping the roles to the appropriate personas.
- Configure and maintain custom presence.
- Create and maintain targeted app experiences for agents and supervisors through app profiles, session templates, and notification templates.
- Enable diagnostics and insights on assignment flow.

### Supervisor

The supervisor persona can manage agents and their work items through routing rules. The supervisor can perform the following tasks:

- Assign or reassign current work items to agents depending on the agent availability and service-level agreement (SLA) of the work item.
- Manage permissions on the data available to agents as part of the interactions (Record-level data permissions).
- Monitor agent interactions and provide help as required.
- Access insights related to agent performance and customer interactions.
- Access diagnostics for the routed records.

### Agent

The agent persona can manage the work items that're assigned to them through custom or default rules set up by the admin persona. The agent can perform the following tasks:

- Manage their work items as follows:
  - Engage with the customers.
  - Reassign work to other agents in the group.
  - Decline interactions.
- Manage their skills.
- Manage their case queues.

## Create custom security roles

Custom security roles can be created at an organizational or business unit level, and you can edit access level for records and tasks. The addition of custom security roles is optional. To ensure persona mapping works, perform the following steps:

1. Identify the tasks that a user will perform.

1. [Create a copy of an existing role](/power-platform/admin/create-edit-security-role#create-a-security-role-by-copy-role) as your starting point. Custom security roles must have correct minimum access levels for the appropriate records to ensure feature functionality. You can copy one of the following predefined security roles:

   - Omnichannel Administrator
   - Omnichannel supervisor
   - Omnichannel agent
   - CSR Manager
   - Customer Service Representative

1. Customize permissions and access levels for your new security role.

1. Save the security role with a name that will help you identify it during persona mapping.

For example, if your organization is expecting a large seasonal increase in chat service requests, you might hire some seasonal employees to exclusively handle chat channels. You can create a security role for the "seasonal service rep". First, you'd identify that users with this role are part of the agent archetype. Knowing that, you'll create a copy of the "Omnichannel agent" security role. By starting with a copied role, you are less likely to face user issues by under-granting privileges. As part of customizing, you might remove read access for records that're not related to chat, such as Survey feedback, SMS, or voice channels. Finally, you can save the new security role as "seasonal service rep".

## Map roles to personas

After persona mapping is enabled, it'll automatically assign default roles depending on the Dynamics 365 services that're enabled for your environment. For an environment with Customer Service Enterprise license, the default mapping includes Customer Service Representative and CSR manager roles. For an environment with Omnichannel for Customer Service, the three primary security roles are mapped to personas. If both services are enabled, both sets of default mappings are included. The following table contains the mapping information for the roles in Customer Service and Omnichannel for Customer Service.

| Service | Admin persona default mapping | Supervisor persona default mapping | Agent persona default mapping |
| ------------- | ---------------- | ------------------- | --------------- |
| Customer Service Enterprise | CSR Manager | CSR Manager | Customer Service Representative |
| Omnichannel for Customer Service | Omnichannel Administrator | Omnichannel supervisor | Omnichannel agent |  
| Customer Service Enterprise + Omnichannel for Customer Service | CSR Manager + Omnichannel Administrator | CSR Manager + Omnichannel supervisor | Customer Service Representative + Omnichannel agent |
|||||

> [!NOTE]
>
> - Customized mappings won't be reset if one of the services is added later.
> - Make sure that the roles you want to map to personas have been assigned to the users directly and not through team memberships.

### Manage personas

You can customize the roles to persona mapping in the Customer Service admin center, Omnichannel admin center, or Customer Service Hub app.

**To customize the role to persona mapping**

1. Go to one of the apps, and perform the following steps.
   
   ### [Customer Service admin center](#tab/customerserviceadmincenter)
   
    - In the site map, select **User management** in **Customer support**. The **User management** page appears.    
   
   ### [Omnichannel admin center](#tab/omnichanneladmincenter)

    - In the site map, select **User attributes** under **Advanced settings**.
    
   ### [Customer Service Hub](#tab/customerservicehub) 

    - Go to the **Service Management** change area, and select **User attributes** from the **Unified routing** menu.

2. Select **Manage** for **Role persona mapping**.

3. Select the persona to add or remove security roles. The **Edit roles** pane displays the list of roles.

4. Select or clear the selection from the checkboxes for the required security roles.

5. Select **Save and Close**.

The updated set of roles are listed for the persona.

   :::image type="content" source="media/role-persona-mapping-view.png" alt-text="A view of the roles mapped to the admin, supervisor, and agent personas.":::

To assign a persona to the "seasonal service rep" role mentioned in the example, select the **Agent** persona. In the **Edit roles** pane, locate the "seasonal service rep" security role and select the checkbox. After you select **Save and Close**, the custom security role will be listed under the agent persona. With role to persona mapping completed, you can now grant access to any applications and forms they would use.

## Enable access to applications

Users with security roles mapped to personas do not get automatic access to associated dashboards or applications. Access needs to be provided by administrators.

Perform the following steps to ensure that access and privileges are provided to users.

1. Create the required user role. More information: [Create users and assign security roles](/power-platform/admin/create-users-assign-online-security-roles)

2. Add and edit user permissions and privileges as required.

3. Sign in to Dynamics 365.

4. Select the ellipsis in the application tile.

5. Select **Manage roles**.

6. In the dialog that appears, select the custom role that you want to grant permission to and select **Save**.

## Enable access to forms and dashboards

To enable access to a form or dashboard, perform the following steps:

1. Sign in to Dynamics 365.

2. Go to **Advanced Settings** > **Settings**.

3. Select **Customizations** in **Customize the system**.

4. From the **Solution Default Solution** list, select **Entities** > **Characteristics**, and then **Forms**.

5. Open an active form, and select **Enable security roles**.

6. Select the role that you want to provide access to, and select **OK**.

### See also

[Overview of unified routing](overview-unified-routing.md)  
[Manage users for unified routing](users-user-profiles.md)  
[Personas and privileges](persona-privilege-mapping.md) 

[!INCLUDE[footer-include](../includes/footer-banner.md)]  
