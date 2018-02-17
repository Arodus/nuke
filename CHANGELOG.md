# Changelog
All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](http://keepachangelog.com/en/1.0.0/)
and this project adheres to [Semantic Versioning](http://semver.org/spec/v2.0.0.html).

## [vNext]
- Deprecated `-target` parameter in favor of passing targets as first argument to the bootstrapping scripts.
- Deprecated `DefaultSettings` which are now exposed in each task class individually.
- Added `-major` and `-minor` switches for bumping versions when using `GitVersionAttribute`.
- Added `ChangelogTasks.FinalizeChangelog` for finalizing unpublished changes to a certain version.
- Added `ChangelogTasks.ExtractChangelogSectionNotes` for extracting release data for a specified tag.
- Added `NukeBuild.InvokedTargets` which exposes targets passed from command-line.
- Added `NukeBuild.ExecutingTargets` which exposes targets that will be executed.
- Added `GitRepository.IsGitHubRepository` extension method.
- Added `GitRepositoryAttribute.Branch` and `GitRepositoryAttribute.Remote` properties for pass-through.
- Added `build.cmd` in setup for easier invocation on Windows.
- Added CLT tasks for Git.
