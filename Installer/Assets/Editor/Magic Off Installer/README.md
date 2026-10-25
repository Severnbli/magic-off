# Magic Off Installer

This folder installs [Magic Off](https://github.com/Severnbli/magic-off) through Package Manager.

On the next domain reload the installer:

- registers the OpenUPM scoped registry in `Packages/manifest.json`, and
- pins `com.severnbli.magic-off` to the installer's version.

Package Manager then downloads and manages the real package, so dependencies resolve automatically and updates work as with any other package. The installer never downgrades: it only writes the version when the installer's version is newer than the one already pinned.

Once the package is installed, this folder can be deleted.
