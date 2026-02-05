MP0: The Room

GitHub Repository:
https://github.com/abhishekramakri/CS-417-MP0

Notes
- This project was developed on macOS.
- OpenXR and XR Interaction Toolkit are integrated, and all interactions are implemented using InputActionReference.
- Actions were created for all required interactions (Quit, Light Toggle, Break Out), with bindings defined for both keyboard input and XR controller input.
- Due to platform limitations (Meta Quest Link not supported on macOS) and administrative restrictions on EWS machines, the video demonstration uses keyboard controls, which was confirmed as acceptable per the updated MP0 rubric.
- The XR Interaction Simulator is included in the project for non-HMD XR testing.
- The same Input Actions are bound to XR controllers and will function with a physical headset without code changes.
- Break Out toggles between inside and outside viewpoints; an outside platform is used as the external vantage point.
 -Since the build was created on macOS, the standalone build is provided as a .app file rather than a Windows .exe.
