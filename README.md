# Facade-Design-Pattern
What Is This Pattern?
The Façade design pattern is a simple structure laid over a more complex structure.
The idea of the Façade is that if you don't want other code accessing the complex bits of a
class or process, you hide those bits by covering them with a Façade.

# The Participants
• The Subsystems are any classes or objects which implement functionality but can be
"wrapped" or "covered" by the Facade to simplify an interface.
• The Facade is the layer of abstraction above the Subsystems, and knows which
Subsystem to delegate appropriate work to.

# A Delicious Example
To demonstrate how we use the Facade pattern, let's think about a restaurant.
In most kitchens, the work area is divided
into sections, such as hot prep, salad prep,
the bar, the fountain, etc.
If you are a patron at a restaurant and you
sit down at a booth, do you care what part of
your meal is made at what section of the
restaurant? Of course not. There is
naturally a layer of abstraction in place:
the server.
The server knows where to place each order
and where to pick those parts of the order
up from. We'll model this relationship to
demonstrate how the Façade pattern can simplify the structure of our code.

# Will I Ever Use This Pattern?
All the damn time. Seriously, the
Façade pattern is so general that it
applies to almost every major app
I've worked on, especially those
where I couldn't refactor or modify
pieces of said apps for various
reasons. You'll probably be using it
a lot, even when you might not notice that a Façade pattern is being applied

# Summary
The Façade pattern is a simple (or at least *simpler*) overlay on top of a group of more
complex subsystems. The Façade knows which Subsystem to direct different kinds of work
toward. And it is really, really common, so it's one of the patterns we should know thoroughly.
