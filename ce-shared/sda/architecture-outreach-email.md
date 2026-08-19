In this scenario, a Sales Development agent autonomously generates and manages outreach emails for a seller using a predefined list of prospects. The prospect list can come from a CRM system or provided manually by the seller. CRM integration is optional and is not required for the scenario to work.

The agent researches each prospect, drafts outreach emails by following approved playbooks and guardrails, and adjusts its messaging as replies come in. Throughout the process, the agent operates within strict security, compliance, and policy controls.

:::image type="content" source="../../ce/sales/sales-dev-agent/media/architecture-outreach-email.png" alt-text="Screenshot of a campaign summary report file.":::

## Scenario flow

1. Prospect list ingestion (precondition)

	Before the workflow starts, the seller provides a list of prospects. The list can be:

	- Uploaded or shared directly by the seller
	- Read from an authorized CRM system

	Once the list is available, the Sales Development agent treats it as the authoritative input for the outreach workflow. CRM connectivity is optional, and the scenario can proceed without it.

2. Sales Development agent initializes the outreach workflow

	The Sales Development agent processes the prospect list sequentially. Using its agentic identity, the agent operates within the seller's tenant and permission scope so that all downstream actions remain attributable and policy-compliant.

	The workflow state is persisted in the M365 Compliant Container, which stores:

	- Progress across the prospect list
	- Per-prospect interaction history
	- Intermediate reasoning and decisions

	This container is a specialized runtime and is not exposed through the Power Platform admin center.

3. Prospect research for each prospect

	Before generating outreach content, the Sales Development agent researches each prospect. This research includes:

	- Bing Search for publicly available information about the prospect and their organization
	- Product information and positioning content retrieved from the agent's knowledge database

	This enrichment step happens internally, even if it is not shown in the diagram. It directly informs the agent's reasoning and content generation. CRM data is not required at this stage. If authorized CRM data is available, the agent can use it as an additional signal, but the workflow does not depend on it.

4. Playbook, guidelines, and guardrails interpretation

	After research is complete, the Sales Development agent interprets:

	- Outreach playbooks that define sequence, intent, and structure
	- Messaging guidelines that define tone, positioning, and constraints
	- Behavioral and policy guardrails

	These inputs are treated as first-class constraints on the reasoning process and are continuously enforced.

	The generative AI component synthesizes:

	- Prospect research
	- Product knowledge
	- Playbook instructions

	The responsible AI component ensures that generated content:

	- Adheres to enterprise and legal requirements
	- Avoids restricted claims and unsafe language
	- Remains appropriate for external communication

5. Outreach email generation and delivery

	The Sales Development agent generates an initial outreach email for the prospect and sends it through Microsoft applications such as Outlook. Depending on the playbook and guidelines, the agent can also hand off to a hiring manager when appropriate.

	All outbound communication is subject to security and compliance enforcement, including policy checks and auditability.

6. State tracking and ongoing execution

	Throughout execution, the M365 Compliant Container tracks:

	- Which prospects have been contacted
	- Which emails have been sent
	- Pending replies and follow-up actions

	This persistent state allows the Sales Development agent to operate autonomously over time without losing continuity or context.

7. Prospect replies and adaptive behavior

	When a prospect replies, the Sales Development agent detects the response through Microsoft applications and reevaluates the current context. At that point:

	- Playbooks, guidelines, and guardrails are applied again
	- The agent determines the next action, such as reply, wait, escalate, or stop
	- Generative AI produces a response aligned to the updated context

	This loop can repeat multiple times for the same prospect, allowing the agent to adapt its behavior as the conversation develops.

8. Continuous security and compliance enforcement

	Security and compliance controls are enforced at every stage of the workflow:

	- Data access is limited by tenant and user permissions
	- External communication policies are applied continuously
	- Actions are logged and auditable

	There is no phase of the workflow in which security or compliance is bypassed or deferred.

## Human oversight

Sales Development agent is designed to operate with human oversight. The following controls ensure that the hiring manager retains authority over the agent's behavior:

- **Configuration approval**: The agent does not begin outreach until the hiring manager explicitly approves it.
- **Behavior changes**: Any agent-proposed update to guidelines or playbooks requires explicit manager approval before it takes effect. The agent never changes its own configuration silently.
- **Hot leads and escalation handoff**: When a prospect is identified as a hot lead or requires escalation, the agent notifies the hiring manager or assigned seller and loops them into the email thread. The agent does not continue autonomous engagement on escalated threads.
- **Pause and stop controls**: The hiring manager can instruct the agent to immediately pause or stop all active outreach. Once a halt is confirmed, no additional emails are sent.

