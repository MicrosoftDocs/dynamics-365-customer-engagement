Sales Development agent processes each incoming message as it arrives. This supports fast response, but it does not wait for internal side discussions to complete before replying.

Two practical limitations follow from that design:

- **Immediate response in multi-party replies**: If a prospect adds a colleague and asks that colleague a question, Sales Development agent responds right away when qualified interest is detected, rather than waiting for the colleague's input.
- **Finality after handoff and escalation**: Once Sales Development agent hands off to a seller, Sales Development agent exits the thread. Later replies in that thread are handled by the seller, and Sales Development agent does not re-enter the conversation.

These boundaries keep ownership clear after qualification while preserving rapid response behavior during automated engagement.

