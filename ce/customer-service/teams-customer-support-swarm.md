



# Customer support swarming for agents

When working on time-sensitive, complex customer issues, there are times when it's useful for agents to be able to leverage the expertise of coworkers outside of their Dynamics 365 Customer Service teams. Typically, agents struggle with finding the right expert(s) and collaborating with them in a single shared space, where they have access to the required information necessary resolve an issue. Using the customer support swarming feature, agents can effortlessly find the right set of experts to work with on a customer issue and collaborate with them directly from the agent desktop.


## Start a swarm

### Prerequisites
To be able to create a swarm when working on a customer issue, you must have the following prerequisites in place.

- Swarming privileges
- Embedded Microsoft Teams chat enabled for the agent desktop

1. To start a swarm, Customer Service command bar, select **Create swarm**. The **Intelligent case swarming (preview)** page opens with the **Case details** displayed on the left side pane.
   The case and account fields are read-only, and are designed to give other swarm participants the associated details about the case.
   > [!Note]
   > If you don't see the **Create swarm** option, check the overflow actions. If you still don't see it, ask your administrator to assign access privileges for you.

1.  On the **Intelligent case swarming (preview)** form, type information into the following fields:
   - **What do you need help with**: Type a succinct question about what you want help with. The question will be used to find skills and experts to help you.
   - **What are some things you have already tried** (optional, 500-character limit): Type the details about steps you've already taken to try to resolve the issue, and any results. These details help confirm that any required processes have been followed, and also provides immediate context for other swarm participants who are invited to collaborate on the issue.
   - **Request skills needed** (optional): As part of the swarm request, the system does the following: 
     - Suggest skills base on case title or other case-related conditions your administrator has defined
     - Attempts to match skills based on your swarm question
     - Suggests skills that have the light bulb icon
    You can also select up to 10 skills manually that you think are relative to the case. (Manually selected skills won't have the light bulb icon next to them.)
 
1. Save and send your swarm invitation. The system finds the minimum set of experts needed to cover as many of the skills suggested or that you added as possible, and then displays a participants section
