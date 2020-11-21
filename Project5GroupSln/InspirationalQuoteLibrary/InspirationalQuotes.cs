﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspirationalQuoteLibrary
{
    public class InspirationalQuotes
    {

        public static string GetRandomQuote()
        {
            // Return a random quote from the array on quotes
            var rand = new Random();
            return quotes[rand.Next(0, quotes.Length)];
        }

        // the following is a subset of the quotes found at
        // https://gist.githubusercontent.com/erickedji/68802/raw/7264f2d232702b4013490a0b2f9286cfa1b817e3/quotes.txt

        private static string[] quotes = new string[] {
@"Don't worry about what anybody else is going to do. The best way to
predict the future is to invent it.
-- Alan Kay",

@"Premature optimization is the root of all evil (or at least most of it)
in programming.
-- Donald Knuth",

@"Keep away from people who try to belittle your ambitions. Small people
always do that, but the really great make you feel that you, too, can
become great.
-- Mark Twain",

@"No problem should ever have to be solved twice.
-- Eric S. Raymond, How to become a hacker",

@"Attitude is no substitute for competence.
-- Eric S. Raymond, How to become a hacker",

@"It is said that the real winner is the one who lives in today but able
to see tomorrow.
-- Juan Meng, Reviewing 'The future of ideas' by Lawrence Lessig",

@"Fools ignore complexity. Pragmatists suffer it. Some can avoid it.
Geniuses remove it.
-- Alan J. Perlis (Epigrams in programming)",

@"A year spent in artificial intelligence is enough to make one believe in
God.
-- Alan J. Perlis (Epigrams in programming)",

@"Dealing with failure is easy: Work hard to improve. Success is also easy
to handle: You've solved the wrong problem. Work hard to improve.
-- Alan J. Perlis (Epigrams in programmi ng)",

@"Within a computer natural language is unnatural.
-- Alan J. Perlis (Epigrams in programming)",

@"You think you know when you learn, are more sure when you can write,
even more when you can teach, but certain when you can program.
-- Alan J. Perlis (Epigrams in programming)",

@"Adapting old programs to fit new machines usually means adapting new
machines to behave like old ones.
-- Alan J. Perlis (Epigrams in programming)",

@"A little learning is a dangerous thing.
-- Alexander Pope",

@"Computer science education cannot make anybody an expert programmer any
more than studying brushes and pigment can make somebody an expert
painter.
-- Eric Raymond",

@"Einstein argued that there must be simplified explanations of nature,
because God is not capricious or arbitrary.
-- Frederick P. Brooks, No Sliver Bullet.",

@"Students should be evaluated on how well they can achieve the goals they
strived to achieve within a realistic context. Students need to learn to
do things, not know things.
-- Roger Schank, Engines for Education",

@"We remember what we learn when we care about performing better and when
we believe that what we have been asked to do is representative of
reality.
-- Roger Schank, Engines for Education",

@"There really is no learning without doing.
-- Roger Schank, Engines for Education",

@"We really have to get over the idea that some stuff is just worth
knowing even if you never do anything with it. Human memories happily
erase stuff that has no purpose, so why try to fill up children's heads
with such stuff?
-- Roger Schank, Engines for Education",

@"La tactique, c'est ce que vous faites quand il y a quelque chose à
faire; la stratégie, c'est ce que vous faites quand il n'y a rien à
faire.
-- Xavier Tartacover",

@"The only problems we can really solve in a satisfactory manner are those
that finally admit a nicely factored solution.
-- E. W. Dijkstra, The humble programmer",

@"The best way to learn to live with our limitations is to know them.
--E. W. Dijkstra, The humble programmer",

@"Ce n'est que par les relations qu'on entretient entre nos différentes
connaissances qu'elles nous restent accessibles.
-- Shnuup, sur l'hypertexte (SELFHTML -> Introduction -> Definitions sur l'hypertexte)",

@"We now come to the decisive step of mathematical abstraction: we forget
about what the symbols stand for. ...[The mathematician] need not be
idle; there are many operations which he may carry out with these
symbols, without ever having to look at the things they stand for.
-- Hermann Weyl, The Mathematical Way of Thinking",

@"An expert is, according to my working definition 'someone who doesn't
need to look up answers to easy questions'.
-- Eric Lippert.",

@"The programmer must seek both perfection of part and adequacy of
collection.
-- Alan J. Perlis",

@"Thus, programs must be written for people to read, and only incidentally
for machines to execute.
-- Alan J. Perlis",

@"Lisp programmers know the value of everything but the cost of nothing.
-- Alan J. Perlis",

@"An interpreter raises the machine to the level of the user program; a
compiler lowers the user program to the level of the machine language.
-- SICP",

@"Everything should be made as simple as possible, but no simpler.
-- Albert Einstein",

@"The great dividing line between success and failure can be expressed in
five words: 'I did not have time.'
-- WestHost weekly newsletter 14 Feb 2003",

@"When your enemy is making a very serious mistake, don't be impolite and
disturb him.
-- Napoleon Bonaparte (allegedly)",

@"A charlatan makes obscure what is clear; a thinker makes clear what is
obscure.
-- Hugh Kingsmill",

@"The three chief virtues of a programmer are: Laziness, Impatience and
Hubris.
-- Larry Wall (Programming Perl)",

@"All non-trivial abstractions, to some degree, are leaky.
-- Joel Spolsky (The Law of Leaky Abstractions)",

@"XML wasn't designed to be edited by humans on a regular basis.
-- Guido van Rossum",

@"Premature abstraction is an equally grevious sin as premature
optimization.
-- Keith Devens",

@"You can have premature generalization as well as premature optimization.
-- Bjarne Stroustrup",

@"He causes his sun to rise on the evil and the good, and sends rain on
the righteous and the unrighteous.
-- Matthew 5:45",

@"A language that doesn't affect the way you think about programming, is
not worth knowing.
-- Alan Perlis",

@"Men never do evil so completely and cheerfully as when they do it from
religious conviction.
-- Blaise Pascal (attributed)",

@"Everybody makes their own fun. If you don't make it yourself, it ain't
fun -- it's entertainment.
-- David Mamet (as relayed by Joss Whedon)",

@"If we wish to count lines of code, we should not regard them as *lines
produced* but as *lines spent*.
-- Edsger Dijkstra		",

@"Omit needless words.
-- William Strunk, Jr. (The Elements of Style)",

@"I have never met a man so ignorant that I couldn't learn something from
him.
-- Galileo Galilei",

@"Philosophy: the finding of bad reasons for what one believes by
instinct.
-- Brave New World (paraphrased)",

@"Fools! Don't they know that tears are a woman's most effective weapon?
-- Catwoman (The Batman TV Series, episode 83)",

@"It's like a condom; I'd rather have it and not need it than need it and
not have it.
-- some chick in Alien vs. Predator, when asked why she
always carries a gun",

@"C++ is history repeated as tragedy. Java is history repeated as farce.
-- Scott McKay",

@"Simplicity takes effort-- genius, even.
-- Paul Graham",

@"Show, don't tell.
-- unknown",

@"In God I trust; I will not be afraid. What can mortal man do to me?
-- David (Psalm 56:4)",

@"Linux is only free if your time has no value.
-- Jamie Zawinski",

@"Code is poetry.
-- wordpress.org",

@"If you choose not to decide, you still have made a choice.
-- Rush (Freewill)",

@"Civilization advances by extending the number of important operations
which we can perform without thinking about them.
-- Alfred North Whitehead (Introduction to Mathematics)		",

@"The function of wisdom is to discriminate between good and evil.
-- Cicero",

@"The reason to do animation is caricature. Good caricature picks out the
essense of the statement and removes everything else. It's not simply
about reproducing reality; It's about bumping it up.
-- Brad Bird, writer and director, The Incredibles",

@"Mistakes were made.
-- Ronald Reagan",

@"I would rather be an optimist and be wrong than a pessimist who proves
to be right. The former sometimes wins, but never the latter.
-- 'Hoots'",

@"What is truth?
-- Pontius Pilate",

@"Life moves pretty fast. If you don't stop and look around once in a
while, you could miss it.
-- Ferris Bueller",

@"Any sufficiently complicated C or Fortran program contains an ad hoc,
informally specified, bug-ridden, slow implementation of half of Common
Lisp.
-- Philip Greenspun (Greenspun's Tenth Rule)",

@"The direct pursuit of happiness is a recipe for an unhappy life.
-- Donald Campbell",

@"It's no trick for talented people to be interesting, but it's a gift to
be interested. We want an organization filled with interested people.
-- Randy S. Nelson (dean of Pixar University)",

@"Why teach drawing to accountants? Because drawing class doesn't just
teach people to draw. It teaches them to be more observant. There's no
company on earth that wouldn't benefit from having people become more
observant.
-- Randy S. Nelson (dean of Pixar University)",

@"All problems in computer science can be solved by another level of
indirection.
-- Butler Lampson	",

@"A designer knows he has arrived at perfection not when there is no
longuer anything to add, but when there is no longuer anything to take
away.
-- Antoine de St Exupery.",

@"For the things we have to learn before we can do them, we learn by doing
them.
-- Aristotle.",

@"There are many ways to avoid success in life, but the most sure-fire
just might be procrastination.
-- Hara Estroff Marano.",

@"PI seconds is a nanocentury.
-- [fact]",

@"A non negative binary integer value x is a power of 2 iff (x & (x-1)) is
0 using 2's complement arithmetic.
-- [fact]",

@"Dont give users the opportunity to lock themselves.
-- unknown",

@"Any fool can make the simple complex, only a smart person can make the
complex simple.
-- unknown",

@"New eyes have X-ray vision.  [someone that hasn't written it is more
likely to spot the bug. 'someone' can be you after a break]
-- William S. Annis",

@"So - what are the most important problems in software engineering? I’d
answer “dealing with complexity”.
-- Mark Chu-Carroll",

@"So the mere constraint of staying in regular contact with us will push
you to make things happen, because otherwise you'll be embarrassed to
tell us that you haven't done anything new since the last time we
talked.
-- Paul Graham (a talk at Y Combinator, for startup creators).",

@"The choice of the university is mostly important for the piece of paper
you get at the end. The education you get depends on you.
-- Andreas Zwinkau",

@"Remember that you are humans in the first place and only after that
programmers.
-- Alexandru Vancea",

@"Humans differ from animals to the degree that they are not merely an end
result of their conditioning, but are able to reflect on their
experiences and strategies, and apply insight to make changes in the way
they live to modify the outcome.
-- SlideTrombone (comment on 'Programming can ruin your life')",

@"As builders and creators finding the perfect solution should not be our
main goal. We should find the perfect problem.
-- Isaac (blog comment)",

@"Just like carpentry, measure twice cut once.
-- Super-sizing YouTube with Python (Mike Solomon, mike@youtube.com)",

@"The good thing about reinventing the wheel is that you get a round one.
-- Douglas Crockford (Author of JSON and JsLint)",

@"I feel it is everybodies obligation to reach for the best in themselves
and use that for the interest of mankind.
-- Corneluis (comment on 'Are you going to change the world? (Really?)')",

@"Abstraction is a form of data compression: absolutely necessary, because
human short-term memory is so small, but the critically important aspect
of abstraction is the algorithm that gets you from the name back to the
'uncompressed' details.
-- Bruce Wilder (blog post comment)",

@"Have you ever noticed that when you sit down to write something, half
the ideas that end up in it are ones you thought of while writing it?
The same thing happens with software. Working to implement one idea
gives you more ideas.
-- Paul Graham, The other road ahead.",

@"In general, we can think of data as defined by some collection of
selectors and constructors, together with specified conditions that
these procedures must fulfill in order to be a valid representation.
-- SICP, What is meant by data?",

@"Resume writing is just like dating, or applying for a bank loan, in that
nobody wants you if you're desperate.
-- Steve Yegge.",

@"It(mastering)’s knowing what you are doing.
-- Joesgoals.com",

@"Well then. How could you possibly live without automated refactoring
tools? How else could you coordinate the caterpillar-like motions of all
Java’s identical tiny legs, its thousands of similar parts?
I’ll tell you how:
Ruby is a butterfly.
-- Stevey, Refactoring Trilogy, Part 1.",

@"You will never become a Great Programmer until you acknowledge that you
will always be a Terrible Programmer.
You will remain a Great Programmer for only as long as you acknowledge
that you are still a Terrible Programmer.
-- Marc (http://kickin-the-darkness.blogspot.com/)",

@"If I tell you I'm good, you would probably think I'm boasting. If I tell
you I'm no good, you know I'm lying.
-- Bruce Lee",

@"If something isn’t working, you need to look back and figure out what
got you excited in the first place.
-- David Gorman (ImThere.com)",

@"Pay attention to opportunity cost at all times. Doing one thing means
not doing other things. This is a form of risk that is very easy to
ignore, to your detriment.
-- Marc Andreessen (http://blog.pmarca.com/)",

@"Seize any opportunity, or anything that looks like opportunity. They are
rare, much rarer than you think...
-- Nassim Nicholas Taleb, 'The Black Swan'.",

@"We tend to seek easy, single-factor explanations of success. For most
important things, though, success actually requires avoiding many
separate causes of failure.
-- Jared Diamond",

@"Things which matter most must never be at the mercy of things which
matter least.
-- Johann Wolfgang Von Goethe (1749-1832)",

@"I think the root of your mistake is saying that macros don't scale to
larger groups. The real truth is that macros don't scale to stupider
groups.
-- Paul Graham, on the Lightweight Languages mailing list.",

@"Argue with idiots, and you become an idiot.
If you compete with slaves you become a slave.
-- Paul Graham and Norbert Weiner, respectively",

@"Always dive down into a problem and get your hands on the deepest issue
behind the problem. All other considerations are to dismissed as
'engineering details'; they can be sorted out after the basic problem
has been solved.
-- Chris Crawford",

@"Don't have good ideas if you aren't willing to be responsible for them.
-- Alan Perlis",

@"It is impossible to sharpen a pencil with a blunt axe. It is equally
vain to try to do it with ten blunt axes instead. 
-- Edsger Dijkstra",

@"If we wish to count lines of code, we should not regard them as lines
produced but as lines spent.
-- Edsger Dijkstra",

@"The most damaging phrase in the language is, It's always been done that
way.
-- Rear Admiral Grace Hopper",

@"The only thing a man should ever be 100% convinced of is his own
ignorance.
-- DJ MacLean",

@"In theory, there’s no difference between theory and practice. But in
practice, there is.
-- Albert Einstein",

@"Act from reason, and failure makes you rethink and study harder.
Act from faith, and failure makes you blame someone and push harder.
--  Erik Naggum",

@"Measure everything you can about the product, and you'll start seeing
patterns.
-- Max Levchin, PayPal founder, Talk at StartupSchool2007",

@"Quality of the people is better than the quality of the business idea.
Crappy people can screw up the best idea in the world.
-- Hadi Partovi & Ali Partovi (iLike.com), Talk at StartupSchool2007",

@"The only constant in the world of hi-tech is change.
-- Mark Ward",

@"Write it properly first. It's easier to make a correct program fast,
than to make a fast program correct.
-- http://www.cpax.org.uk/prg/",

@"J'ai toujours préféré la folie des passions à la sagesse de
l'indifférence.
-- Anatole France",

@"You can’t get to version 500 if you don’t start with a version 1.
-- BetterExplained.com",

@"The wonderful and frustrating thing about understanding yourself is that
nobody can do it for you.
-- BetterExplained.com",

@"When you have eliminated the impossible, whatever remains, however
improbable, must be the truth.
-- Sherlock Holmes",

@"In order to understand what another person is saying, you must assume
that it is true and try to find out what it could be true of.
-- George Miller",

@"A journey of a thousand miles must begin with a single step.
-- Lao­Tzu",

@"C’s great for what it’s great for.
-- Ben Hoyts (micropledge)",

@"There is one meaning [for static in C]: a global variable that is
invisible outside the current scope, be it a function or a file.
-- Paolo Bonzini",

@"Processors don't get better so that they can have more free time.
Processors get better so _you_ can have more free time.
-- LeCamarade (freeshells.ch)",

@"Understanding why C++ is the way it is helps a programmer use it well. A deep
understanding of a tool is essential for an expert craftsman.
-- Bjarne Stroustrap",

@"No art, however minor, demands less than total dedication if you want to
excel in it.
-- Alberti",

@"The minute you put the blame on someone else you’ve switch things from
being a problem you can control to a problem outside of your control.
-- engtech (internetducttape.com)",

@"State is the root of all evil. In particular functions with side effects
should be avoided.
-- OO Sucks (bluetail.com)",

@"Ils ne sont pas forts parce qu'ils sont forts. Ils sont forts parce que
nous sommes faibles.
-- Ragala Khalid",

@"It is better to be quiet and thought a fool than to open your mouth and
remove all doubt.
-- WikiHow",

@"A tail call allows a function to return the result of another function
without leaving an entry on the stack. Tail recursion is a specific case
of tail calling.
-- ASPN : Python Cookbook : Explicit Tail Call",

@"Simplicity means the achievement of maximum effect with minimum means.
-- Dr. Koichi Kawana",

@"Normality is the route to nowhere.
-- Ridderstrale & Nordstorm, Funky Business",

@"The problem is that Microsoft just has no taste. And I don't mean that
in a small way, I mean that in a big way.
-- Steve Jobs",

@"Do you want to sell sugared water all your life or do you want to change
the world?
-- Steve Jobs, to John Sculley (former Pepsi executive)",

@"Good work is no done by ‘humble’ men.
-- H. Hardy, A mathematician's apology.",

@"Simplicity and pragmatism beat complexity and theory any day.
-- Dennis (blog comment)",

@"Remember, always be yourself ... unless you suck!
-- Joss Whedon",

@"All great things require great dedication.
-- Chuck Norris(?)",

@"I'm always happy to trade performance for readability as long as the
former isn't already scarce.
-- Crayz (Commentor on blog.raganwald.com)",

@"The definition of insanity is doing the same thing over and over again
and expecting different results.
-- Benjamin Franklin",

@"A no uttered from the deepest conviction is better than a yes merely
uttered to please or what is worse, to avoid trouble.
-- Mahatma Gandhi",

@"The general principle for complexity design is this: Think locally, act
locally.
-- Richard P. Gabriel & Ron Goldman, Mob Software: The Erotic Life of Code",

@"Programming is the art of figuring out what you want so precisely that
even a machine can do it.
-- Some guy who isn't famous",

@"Remember: you are alone. Every time you can get help from someone,
it is an opportunity: you should eagerly size it. But then, promptly
return to normal mode: you are alone and you must be prepared to solve
every problem yourself.
-- Eric KEDJI",

@"Making All Software Into Tools Reduces Risk.
-- smoothspan.com",

@"Some may say Ruby is a bad rip-off of Lisp or Smalltalk, and I admit
that. But it is nicer to ordinary people.
-- Matz, LL2",

@"C and Lisp stand at opposite ends of the spectrum; they're each great at
what the other one sucks at.
-- Steve Yegge, Tour de Babel.",

@"Two people should stay together if together they are better people than
they would be individually.
-- ?",

@"To the optimist, the glass is half full. To the pessimist, the glass is
half empty. To the engineer, the glass is twice as big as it needs to
be.
-- author unknown (quoted in `Robust Systems', Gerald Jay Suseman)",

@"It is practically impossible to teach good programming to students that
have had a prior exposure to BASIC: as potential programmers they are
mentally mutilated beyond hope of regeneration.
-- Edsger Dijkstra",

@"Whatever is worth doing at all, is worth doing well.
-- Earl of Chesterfield",

@"Rules of Optimization:
Rule 1: Don’t do it.
Rule 2 (for experts only): Don’t do it yet.
-- M.A. Jackson",

@"More computing sins are committed in the name of efficiency (without
necessarily achieving it) than for any other single reason - including
blind stupidity.
-- W.A. Wulf",

@"We should forget about small efficiencies, say about 97% of the time:
premature optimization is the root of all evil.
-- Donald Knuth",

@"The best is the enemy of the good.
-- Voltaire",

@"The job of a leader today is not to create followers. It’s to create
more leaders.
-- Ralph Nader",

@"The president was visiting NASA headquarters and stopped to talk to a
man who was holding a mop. “And what do you do?” he asked. The man, a
janitor, replied, “I’m helping to put a man on the moon, sir.”
-- The little book of leadership",

@"Only make new mistakes.
-- Phil Dourado",

@"You can recognize truth by its beauty and simplicity. When you get it
right, it is obvious that it is right.
-- Richard Feynman",

@"Talkers are no good doers.
-- William Shakespeare, 'Henry VI'",

@"Photography is painting with light.
-- Eric Hamilton",

@"Good artists copy. Great artists steal.
-- Pablo Picasso",

@"The problem is that small examples fail to convince, and large examples
are too big to follow.
-- Steve Yegge.",

@"We are the sum of our behaviours; excellence therefore is not an act but
a habit.
-- Aristotle.",

@"The purpose of abstraction is not to be vague, but to create a new
semantic level in which one can be absolutely precise.
-- Edsger Dijkstra",

@"Every man prefers belief to the exercise of judgment.
-- Seneca",

@"It’s hard to grasp abstractions if you don’t understand what they’re
abstracting away from.
-- Nathan Weizenbaum",

@"That is one of the most distinctive differences between school and the
real world: there is no reward for putting in a good effort. In fact,
the whole concept of a 'good effort' is a fake idea adults invented to
encourage kids. It is not found in nature.
-- Paul Graham",

@"I find that the harder I work, the more luck I seem to have.
-- Thomas Jefferson",

@"Don't stay in bed, unless you can make money in bed.
-- George Burns",

@"If everything seems under control, you're not going fast enough.
-- Mario Andretti",

@"Chance favors the prepared mind.
-- Louis Pasteur",

@"Controlling complexity is the essence of computer programming.
-- Brian Kernigan",

@"The function of good software is to make the complex appear to be
simple.
-- Grady Booch",

@"Programmers are in a race with the Universe to create bigger and better
idiot-proof programs, while the Universe is trying to create bigger and
better idiots.  So far the Universe is winning.
-- Rich Cook",

@"A hacker on a roll may be able to produce–in a period of a few
months–something that a small development group (say, 7-8 people) would
have a hard time getting together over a year.  IBM used to report that
certain programmers might be as much as 100 times as productive as other
workers, or more.
-- Peter Seebach",

@"The best programmers are not marginally better than merely good ones.
They are an order-of-magnitude better, measured by whatever standard:
conceptual creativity, speed, ingenuity of design, or problem-solving
ability.
-- Randall E. Stross",

@"A great lathe operator commands several times the wage of an average
lathe operator, but a great writer of software code is worth 10,000
times the price of an average software writer.
-- Bill Gates",

@"Measuring programming progress by lines of code is like measuring
aircraft building progress by weight.
-- Bill Gates",

@"First learn computer science and all the theory.  Next develop a
programming style.  Then forget all that and just hack.
-- George Carrette",

@"To iterate is human, to recurse divine.
-- L. Peter Deutsch",

@"The best thing about a boolean is even if you are wrong, you are only
off by a bit.
-- Anonymous",

@"Should array indices start at 0 or 1?  My compromise of 0.5 was rejected
without, I thought, proper consideration.
-- Stan Kelly-Bootle",

@"The use of COBOL cripples the mind; its teaching should therefore be
regarded as a criminal offense.
-- E.W. Dijkstra",

@"It is practically impossible to teach good programming style to students
that have had prior exposure to BASIC.  As potential programmers, they
are mentally mutilated beyond hope of regeneration.
-- E. W. Dijkstra",

@"One of the main causes of the fall of the Roman Empire was that–lacking
zero–they had no way to indicate successful termination of their C
programs.
-- Robert Firth",

@"Saying that Java is nice because it works on all OSes is like saying
that anal sex is nice because it works on all genders.
-- Alanna",

@"If Java had true garbage collection, most programs would delete
themselves upon execution.
-- Robert Sewell",

@"Software is like sex: It’s better when it’s free.
-- Linus Torvalds",

@"Any code of your own that you haven’t looked at for six or more months
might as well have been written by someone else.
-- Eagleson’s Law",

@"Good programmers use their brains, but good guidelines save us having to
think out every case.
-- Francis Glassborow",

@"Considering the current sad state of our computer programs, software
development is clearly still a black art, and cannot yet be called an
engineering discipline.
-- Bill Clinton",

@"If debugging is the process of removing bugs, then programming must be
the process of putting them in.
-- Edsger W. Dijkstra",

@"Always code as if the guy who ends up maintaining your code will be a
violent psychopath who knows where you live.
-- Martin Golding",

@"Everything that can be invented has been invented.
-- Charles H. Duell, Commissioner, U.S. Office of Patents, 1899",

@"I think there’s a world market for about 5 computers.
-- Thomas J. Watson, Chairman of the Board, IBM, circa 1948",

@"It would appear that we have reached the limits of what it is possible
to achieve with computer technology, although one should be careful with
such statements, as they tend to sound pretty silly in 5 years. 
-- John Von Neumann, circa 1949",

@"But what is it good for?
-- Engineer at the Advanced Computing Systems Division of IBM,
commenting on the microchip, 1968",

@"There is no reason for any individual to have a computer in his home.
-- Ken Olson, President, Digital Equipment Corporation, 1977",

@"640K ought to be enough for anybody.
-- Bill Gates, 1981",

@"Windows NT addresses 2 Gigabytes of RAM, which is more than any
application will ever need.
-- Microsoft, on the development of Windows NT, 1992",

@"We will never become a truly paper-less society until the Palm Pilot
folks come out with WipeMe 1.0.
-- Andy Pierson",

@"If it keeps up, man will atrophy all his limbs but the push-button
finger.
-- Frank Lloyd Wright",

@"Functional programming is like describing your problem to a
mathematician.  Imperative programming is like giving instructions to
an idiot.
-- arcus, #scheme on Freenode",

@"Lisp is a programmable programming language.
-- John Foderaro",

@"I guess, when you're drunk, every woman looks beautiful and every
language looks (like) a Lisp :)
-- Lament, #scheme@freenode.net",

@"Many of life's failures are people who did not realize how close they
were to success when they gave up.
-- Thomas Edison",

@"The only way of discovering the limits of the possible is to venture a
little way past them into the impossible.
-- Arthur C. Clarke",

@"Any sufficiently advanced technology is undistinguishable from magic.
-- Arthur C. Clarke",

@"Good ideas are out there for anyone with the wit and the will to find
them.
-- Malcolm Gladwell, Who says big ideas are rare?",

@"Training research shows that if you get speed now you can get quality
later. But if you don't get speed you will never get quality in the long
run.
-- Philip Greenspun",

@"Beware of bugs in the above code; I have only proved it correct, not
tried it.
-- Donald Knuth",

@"Wear your best for your execution and stand dignified. Your last
recourse against randomness is how you act — if you can’t control
outcomes, you can control the elegance of your behaviour. You will
always have the last word.
-- Nassim Taleb",

@"The human brain starts working the moment you are born and never stops
until you stand up to speak in public.
-- Anonymous",

@"The trouble with the world is that the stupid are always cocksure and
the intelligent are always filled with doubt.
-- Bertrand Russell",

@"Simple, clear purpose and principles give rise to complex, intelligent
behavior. Complex rules and regulations give rise to simple, stupid
behavior.
-- Dee Hock, Birth of the Chaordic Age",

@"C++ is like teenage sex: Everybody is talking about it all the time,
only few are really doing it.
-- unknown",

@"Functional programming is to algorithms as the ubiquitous little black
dress is to women's fashion.
-- Mark Tarver (of 'The bipolar Lisp programmer' fame)",

@"Java and C++ make you think that the new ideas are like the old ones.
Java is the most distressing thing to hit computing since MS-DOS.
-- Alan Kay",

@"For complex systems, the compiler and development environment need to be
in the same language that its supporting. It's the only way to grow
code.
-- Alan Kay",

@"Simple things should be simple. Complex things should be possible.
-- Alan Kay",

@"I invented the term Object-Oriented, and I can tell you I did not have
C++ in mind.
-- Alan Kay",

@"All creativity is an extended form of a joke.
-- Alan Kay",

@"If you don't fail at least 90 percent of the time, you're not aiming
high enough.
-- Alan Kay",

@"Revolutions come from standing on the shoulders of giants and facing in
a better direction.
-- Alan Kay",

@"Ce n’est que par les beaux sentiments qu’on parvient à la fortune !
-- Charles Baudelaire, Conseils aux jeunes littérateurs.",

@"La haine est une liqueur précieuse, un poison plus cher que celui des
Borgia, - car il est fait avec notre sang, notre santé, notre sommeil,
et les deux tiers de notre amour! Il faut en être avare!
-- Charles Baudelaire, Conseils aux jeunes littérateurs.",

@"L’art qui satisfait le besoin le plus impérieux sera toujours le plus
honoré.
-- Charles Baudelaire, Conseils aux jeunes littérateurs.",

@"If it looks like a duck, walks like a duck, and quacks like a duck, it's
a duck.
-- Official definition of 'duck typing'",


@"Des mots simples, quand ils sont bien utilisés, font faire à des gens
ordinaires des choses extraordinaires.
-- Khaled TANGAO",

@"It was Edison who said ‘1% inspiration, 99% perspiration’. That may have
been true a hundred years ago. These days it's ‘0.01% inspiration,
99.99% perspiration’, and the inspiration is the easy part.
-- Linux Torvalds",

@"The greatest challenge to any thinker is stating the problem in a way
that will allow a solution.
-- Bertrand Russell",

@"No matter how much you plan you’re likely to get half wrong anyway. So
don’t do the ‘paralysis through analysis’ thing. That only slows
progress and saps morale.
-- 37 Signal, Getting real",

@"The ability to simplify means to eliminate the unnecessary so that the
necessary may speak.
-- Hans Hofmann",

@"However beautiful the strategy, you should occasionally look at the
results.
-- Winston Churchill",

@"Genius is 1% inspiration and 99% perspiration.
-- Thomas Edison",

@"I’d rather write programs to write programs than write programs.
-- Richard Sites",

@"Heureux l'étudiant qui comme la Rivière peut suivre son cours sans
quitter son lit...
-- Sebastien, sur commentcamarche.net",

@":nunmap can also be used outside of a monastery.
-- Vim user manual",

@"I had to learn how to teach less, so that more could be learned.
-- Tim Gallwey, The inner game of work",

@"The Work Begins Anew, The Hope Rises Again, And The Dream Lives On.
-- Ted Kennedy",

@"The hardest part of design ... is keeping features out.
-- Donald Norman ",

@"Before software can be reusable it first has to be usable.
-- Ralph Johnson ",

@"The opposite of love is not hate, it is indifference.
-- Elie Wiesel",

@"Perpetual optimism is a force multiplier.
-- Colin Powell",

@"Be the change you want to see in the world.
-- Mahatma Gandhi",

@"The art of getting someone else to do something you want done because he
wants to do it [Leadership].
-- Dwight D. Enseinhover.",

@"No one is all evil. Everybody has a good side. If you keep waiting, it
will comme up.
-- Randy Pausch",

@"Experience is what you get when you don't get what you want.
-- Cited by Randy Pausch",

@"Luck is where preparation meets opportunity.
-- Randy Pausch",

@"Bonne bosse et reste le boss.
-- Darryl Amedon",

@"The greatest of all weaknesses is the fear of appearing weak.
-- J. B. Bossuet, Politics from Holy Writ, 1709",

@"It's easier to ask forgiveness than it is to get permission.
-- Rear Admiral Dr. Grace Hopper",

@"An investment in knowledge always pays the best interest.
-- Benjamin Franklin",

@"Natives who beat drums to drive off evil spirits are objects of scorn to
smart Americans who blow horns to break up traffic jams.
-- Mary Ellen Kelly",

@"Never do the impossible. People will expect you to do it forever after.
-- pigsandfishes.com",

@"Give up control. You never really had it anyway.
-- How to fail: 25 secrets learned through failure",

@"Ne te mets pas de limite, la vie se chargera de la mettre a ta place.
-- Darryl AMEDON",

@"Only two things are infinite, the universe and human stupidity. And I'm not so
sure about the former.
-- Albert Einstein",

@"The important thing is not to stop questioning.
-- Albert Einstein",

@"Do not accept anything because it comes from the mouth of a respected person.
-- Buddha",

@"Work as intensely as you play and play as intensely as you work.
-- Eric S. Raymond, How To Be A Hacker",

@"A witty saying proves nothing
-- Voltaire",

@"Sound methodology can empower and liberate the creative mind; it cannot inflame
or inspire the drudge.
-- Frederick P. Brooks, No Sliver Bullet.",

@"La connaissance d'un défaut ne l'enlève pas, elle nous torture jusqu'à sa
correction.
-- Daniel Lovewin (Guillaume Kpotufe)",

@"Je crois au flooding.
-- Karim BAINA (en parlant du dailogue avec les administrations)",


@"Do not spoil what you have by desiring what you have not; but remember that what
you now have was once among the things only hoped for.
-- Greek philosopher Epicurus",

@"Nobody can make you feel inferior without your consent.
-- Eleanor Roosevelt",

@"If you tell the truth, you don't have to remember anything.
-- Mark Twain",

@"You know you're in love when you can't fall asleep because reality is finally
better than your dreams.
-- Dr. Seuss",

@"The opposite of love is not hate, it's indifference.
-- Elie Wiesel",

@"Life is what happens to you while you're busy making other plans.
-- John Lennon",

@"Whenever you find yourself on the side of the majority, it is time to pause and
reflect.
-- Mark Twain",

@"To be yourself in a world that is constantly trying to make you something else
is the greatest accomplishment.
-- Ralph Waldo Emerson",

@"It is not a lack of love, but a lack of friendship that makes unhappy marriages.
-- Friedrich Nietzsche",

@"In terms of energy, it's better to make a wrong choice than none at all.
-- George Leonard, Mastery.",

@"Courage is grace under pressure.
-- Ernest Hemingway",

@"Actually, the essence of boredom is to be found in the obsessive search for
novelty. Satisfaction lies in mindful repetition, the discovery of endless
richness in subtle variations on familiar themes.
-- George Leonard, Mastery.",

@"Before enlightenment, chop wood and carry water.
After enlightenment, chop wood and carry water.
-- Ancient Eastern adage",

@"Acknowledging the negative doesn't mean sniveling [whining, complaining]; it
means facing the truth and then moving on.
-- George Leonard, Mastery.",

@"Whatever you can do, or dream you can, begin it. Boldness has genius, power, and
magic in it.
-- Goethe",

@"What we choose to fight is so tiny!
What fights us is so great!
...
When we win it's with small things,
and the triumph itself makes us small.
...
Winning does not tempt that man.
This is how he grows: by being defeated, decisively,
by constantly greater beings. 
-- Rainer Maria Rilke, The Man Watching.",

@"Are you willing to wear your white belt?
-- George Leonard, Mastery."
        };
    }
}
