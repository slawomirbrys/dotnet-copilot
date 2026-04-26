---
name: Always use feature branches for PR workflow
description: User wants a feature branch created before committing so a PR can be raised
type: feedback
---

Always create a feature branch (e.g. `feature/<short-description>`) before committing changes, so that a pull request from that branch to `main` can be opened on GitHub.

**Why:** Committing directly to `main` makes it impossible to open a PR, which the user wants for code review workflow.

**How to apply:** At the start of any commit task, check the current branch. If on `main`, create and switch to a feature branch first, then commit and push from there, then open the PR targeting `main`.
