using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class removedLessonDescAndContent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "lessonContent",
                table: "lessons");

            migrationBuilder.DropColumn(
                name: "lessonDescription",
                table: "lessons");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "lessonContent",
                table: "lessons",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lessonDescription",
                table: "lessons",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 1,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Content covering basic algebraic notation and terminology.", "Introduction to variables and expressions." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 2,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Step-by-step examples of solving linear equations.", "Techniques for solving single-variable linear equations." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 3,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Graphing inequalities on a number line and solving.", "Understanding and solving linear inequalities." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 4,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Defining functions and evaluating function values.", "Basic concepts of functions, domain, and range." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 5,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Adding, subtracting, and multiplying polynomials.", "Introduction to polynomial expressions and operations." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 6,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Evaluating limits and understanding continuity.", "Understanding the concept of limits in calculus." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 7,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Calculating derivatives using the power rule.", "Defining the derivative and basic differentiation rules." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 8,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Applying advanced differentiation rules.", "Product rule, quotient rule, and chain rule." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 9,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Solving related rates and optimization problems.", "Using derivatives to find rates of change and optimization." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 10,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Understanding the indefinite integral.", "Basic concepts of integration and antiderivatives." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 11,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Definitions and postulates of basic geometric elements.", "Fundamental concepts of geometry." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 12,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Measuring angles, complementary and supplementary angles.", "Types of angles and their properties." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 13,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Identifying alternate interior, corresponding angles, etc.", "Properties of angles formed by parallel lines." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 14,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "SSS, SAS, ASA congruence postulates.", "Classifying triangles and proving congruence." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 15,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Calculating interior angles and classifying polygons.", "Properties of polygons, focusing on quadrilaterals." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 16,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "SOH CAH TOA and solving right triangles.", "Sine, cosine, and tangent in right triangles." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 17,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Finding trig values for standard angles.", "Understanding trigonometric functions using the unit circle." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 18,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Amplitude, period, and phase shift.", "Graphing sine, cosine, and tangent functions." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 19,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Pythagorean identities, sum/difference identities.", "Fundamental trigonometric identities." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 20,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Finding solutions within a given interval.", "Techniques for solving equations involving trig functions." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 21,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Populations, samples, descriptive vs. inferential statistics.", "Types of data and data collection methods." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 22,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Mean, median, mode, variance, standard deviation.", "Measures of central tendency and dispersion." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 23,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Histograms, box plots, scatter plots.", "Graphical representation of data." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 24,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Sample spaces, events, conditional probability.", "Introduction to probability rules." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 25,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Binomial and Normal distributions basics.", "Understanding probability distributions." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 26,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Defining events and calculating basic probabilities.", "Axioms of probability and sample spaces." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 27,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Bayes' Theorem and its applications.", "Understanding dependent and independent events." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 28,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Probability mass functions and density functions.", "Discrete and continuous random variables." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 29,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Properties of expectation and variance.", "Calculating measures for random variables." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 30,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Applications and calculations for common distributions.", "Detailed look at Binomial, Poisson, Normal distributions." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 31,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Truth tables, logical equivalences, direct proof, proof by contradiction.", "Propositional logic and methods of proof." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 32,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Union, intersection, complement, power sets.", "Operations on sets, Venn diagrams." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 33,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "The pigeonhole principle, binomial coefficients.", "Permutations and combinations." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 34,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Equivalence relations, injective, surjective functions.", "Properties of relations and types of functions." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 35,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Vertices, edges, paths, cycles, graph coloring.", "Basic concepts of graphs and trees." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 36,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Equations of motion for constant acceleration.", "Motion, velocity, and acceleration." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 37,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Adding vectors, resolving vectors into components.", "Projectile motion and vector operations." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 38,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Applying Newton's first, second, and third laws.", "Force, mass, and acceleration." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 39,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Conservation of energy principle.", "Concepts of work, kinetic and potential energy." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 40,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Conservation of momentum in collisions.", "Linear momentum and impulse." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 41,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Calculating electrostatic forces.", "Properties of electric charge and forces between charges." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 42,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Calculating electric fields for point charges.", "Concept of the electric field and field lines." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 43,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Calculating potential for point charges and systems.", "Potential difference and electric potential energy." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 44,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Calculating capacitance for parallel plate capacitors.", "Capacitors and energy storage." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 45,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Applying Ohm's Law to simple circuits.", "Basics of electric current and resistance." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 46,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Calculating magnetic force using the Lorentz force law.", "Introduction to magnetic fields and forces on moving charges." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 47,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Calculating fields for wires and loops.", "Magnetic fields produced by currents (Biot-Savart Law)." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 48,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Applications for solenoids and toroids.", "Using Ampere's Law to find magnetic fields." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 49,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Induced EMF and magnetic flux.", "Faraday's Law of Induction and Lenz's Law." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 50,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "RL circuits and energy stored in inductors.", "Self-inductance and mutual inductance." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 51,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Properties of light waves.", "Wave-particle duality and the electromagnetic spectrum." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 52,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Total internal reflection and index of refraction.", "Laws of reflection and Snell's Law of refraction." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 53,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Ray tracing and the thin lens equation.", "Converging and diverging lenses." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 54,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Young's double-slit experiment.", "Principle of superposition and interference patterns." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 55,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Single-slit diffraction patterns.", "Diffraction of light through slits and gratings." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 56,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Specific heat and calorimetry.", "Concepts of thermal energy, temperature scales, and heat transfer." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 57,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Conservation of energy in thermal systems.", "Internal energy, work, and heat in thermodynamic processes." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 58,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "PV=nRT and kinetic theory of gases.", "Behavior of ideal gases." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 59,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Heat engines and refrigerators.", "Entropy and the direction of thermodynamic processes." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 60,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Efficiency of heat engines.", "Analyzing cycles like the Carnot cycle." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 61,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Planck's constant and energy quanta.", "The ultraviolet catastrophe and quantization of energy." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 62,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Work function and stopping potential.", "Einstein's explanation and the particle nature of light." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 63,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Electron diffraction experiments.", "De Broglie hypothesis and matter waves." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 64,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Quantized energy levels and spectral lines.", "Early model of the hydrogen atom." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 65,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Probability interpretation and uncertainty principle.", "The Schrödinger equation and wave functions." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 66,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Inertial frames and the constancy of the speed of light.", "Postulates of special relativity." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 67,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Relativistic effects on time and space.", "Consequences of special relativity." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 68,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "E=mc² and its implications.", "Modifications to classical momentum and energy." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 69,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Conceptual overview of general relativity.", "Principle of equivalence and gravity as spacetime curvature." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 70,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Observational evidence for general relativity.", "Gravitational lensing, black holes, and gravitational waves." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 71,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Basic cell structures and functions.", "Prokaryotic vs. Eukaryotic cells." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 72,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Passive transport, active transport, endocytosis.", "The fluid mosaic model and transport mechanisms." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 73,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Nucleus, mitochondria, chloroplasts, ER, Golgi.", "Structure and function of major organelles." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 74,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Glycolysis, Krebs cycle, electron transport chain.", "Overview of energy production in cells." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 75,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Interphase, prophase, metaphase, anaphase, telophase.", "Phases of the cell cycle and cell division." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 76,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Dominance, segregation, independent assortment.", "Principles of inheritance discovered by Mendel." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 77,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Base pairing rules, enzymes involved in replication.", "The double helix structure and DNA synthesis." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 78,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Process of transcription, RNA polymerase.", "From DNA to RNA." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 79,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Ribosomes, codons, tRNA, protein synthesis.", "From RNA to Protein." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 80,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Point mutations, chromosomal mutations, sources of variation.", "Types of mutations and their effects." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 81,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Human skeleton overview, bone composition.", "Types of skeletons and bone structure." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 82,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Skeletal, smooth, cardiac muscle; sliding filament theory.", "Types of muscles and muscle contraction." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 83,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Analyzing movement from a mechanical perspective.", "Forces and levers in biological systems." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 84,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Walking, running, swimming, flying adaptations.", "Different modes of animal movement." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 85,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Motor neurons, reflexes, brain control centers.", "How the nervous system coordinates muscle action." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 86,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Organisms, populations, communities, ecosystems, biosphere.", "Levels of ecological organization." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 87,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Exponential and logistic growth, carrying capacity.", "Population growth models and limiting factors." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 88,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Competition, predation, symbiosis, biodiversity.", "Species interactions within communities." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 89,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Food webs, trophic levels, biogeochemical cycles.", "Energy flow and nutrient cycling." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 90,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Threats to biodiversity and conservation efforts.", "Major terrestrial and aquatic biomes." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 91,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Meristems and primary/secondary growth.", "Basic anatomy of plants: roots, stems, leaves." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 92,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Xylem, phloem, transpiration.", "Water and nutrient transport in plants." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 93,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Light-dependent reactions and the Calvin cycle.", "The process of converting light energy to chemical energy." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 94,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Flower structure, pollination, fertilization, seed development.", "Asexual and sexual reproduction in plants." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 95,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Auxins, gibberellins, phototropism, gravitropism.", "Chemical signaling in plants." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 96,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Body plans, symmetry, evolutionary relationships.", "Major animal phyla and characteristics." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 97,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Sponges, cnidarians, flatworms, roundworms.", "Focus on simpler invertebrates." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 98,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Mollusks, annelids, arthropods, echinoderms.", "Focus on more complex invertebrates." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 99,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Characteristics of chordates, evolution of fish.", "Introduction to Chordates and Fish." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 100,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Key characteristics and adaptations of terrestrial vertebrates.", "Amphibians, Reptiles, Birds, and Mammals." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 101,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Microbial diversity and history of microbiology.", "Overview of bacteria, archaea, viruses, fungi, protists." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 102,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Gram staining and bacterial morphology.", "Cell walls, flagella, capsules, endospores." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 103,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Binary fission, nutritional types.", "Requirements for growth, growth curve, metabolic pathways." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 104,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Lytic vs. lysogenic cycles, viral diseases.", "Structure, replication cycles, and characteristics." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 105,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Pathogens, decomposers, biotechnology.", "Microbes in ecosystems, disease, and industry." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 106,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Lewis structures, VSEPR theory, hybridization.", "Structure, bonding, and properties of organic molecules." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 107,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Naming alkanes (IUPAC), Newman projections.", "Nomenclature and conformations." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 108,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "R/S configuration, optical activity.", "Chirality, enantiomers, diastereomers." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 109,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Arrows formalism, reaction energy diagrams.", "Reaction types, mechanisms, and thermodynamics." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 110,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Pi bonds, electrophilic addition basics.", "Structure, nomenclature, and introduction to addition reactions." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 111,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Electron configurations, ionization energy, electronegativity.", "Review of atomic models and periodic trends." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 112,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Predicting molecular geometry.", "Ionic and covalent bonding theories." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 113,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Hybridization, MO diagrams for diatomic molecules.", "Advanced bonding theories." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 114,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Acid strength, hard/soft acids and bases.", "Bronsted-Lowry and Lewis definitions." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 115,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Nomenclature and basic structures.", "Transition metals, ligands, and complex ions." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 116,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Gas laws, Maxwell-Boltzmann distribution.", "Ideal and real gas behavior." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 117,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "State functions, calorimetry.", "Energy, work, heat, enthalpy." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 118,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Calculating entropy changes, absolute entropy.", "Entropy, spontaneity, Gibbs free energy." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 119,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Rate laws, activation energy, Arrhenius equation.", "Reaction rates and mechanisms." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 120,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Particle in a box, hydrogen atom basics.", "Basic principles and applications." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 121,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Significant figures, precision vs. accuracy, basic stats.", "Role of analytical chemistry, errors, and data analysis." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 122,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Precipitation methods, titration techniques.", "Classical methods of analysis." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 123,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "UV-Vis spectroscopy, Beer-Lambert Law.", "Interaction of light and matter." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 124,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Gas chromatography (GC) and Liquid chromatography (LC) overview.", "Principles of separation techniques." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 125,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Potentiometry, voltammetry basics.", "Techniques based on electrical properties." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 126,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Peptide bonds, primary to quaternary structure.", "Structure and properties of amino acids and protein hierarchy." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 127,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Michaelis-Menten kinetics, enzyme inhibition.", "Biological catalysts and reaction rates." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 128,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Glycosidic bonds, common sugars.", "Structure and function of monosaccharides and polysaccharides." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 129,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Fatty acids, triglycerides, phospholipids, fluid mosaic model.", "Types of lipids and biological membrane structure." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 130,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Anabolism vs. catabolism, ATP production.", "Introduction to major pathways like glycolysis." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 131,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Ozone layer, greenhouse effect, air pollution.", "Composition and reactions in the atmosphere." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 132,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Water quality parameters (pH, DO), water pollution.", "Chemical processes in water bodies." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 133,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Nutrient cycles, soil contamination.", "Composition and chemical reactions in soil." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 134,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Dose-response relationships, environmental risk.", "Effects of chemicals on organisms and ecosystems." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 135,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Waste reduction, sustainable chemistry practices.", "Principles for designing safer chemical processes." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 136,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Operators, eigenfunctions, eigenvalues.", "Postulates and mathematical framework." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 137,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Variation principle, perturbation theory.", "Techniques for solving the Schrödinger equation." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 138,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Point groups, character tables.", "Using symmetry to simplify chemical problems." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 139,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Hartree-Fock, Density Functional Theory (DFT) basics.", "Overview of computational techniques." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 140,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Partition functions, ensemble theory.", "Connecting microscopic properties to macroscopic behavior." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 141,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Theme, plot, character, setting, point of view.", "Tools and techniques for interpreting literature." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 142,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Examining notable short stories.", "Analyzing elements of short fiction." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 143,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Meter, rhyme, imagery, metaphor, sonnets.", "Understanding poetic devices and forms." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 144,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Context, structure, and major themes in a sample novel.", "Approaches to reading and analyzing novels." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 145,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Dialogue, stage directions, character arcs in plays.", "Elements of dramatic literature." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 146,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Exercises in tone, perspective, and style.", "Developing a unique writing style." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 147,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Character archetypes, backstory, motivations.", "Creating believable and engaging characters." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 148,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Three-act structure, outlining techniques, pacing.", "Crafting compelling narratives." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 149,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Using sensory details, creating atmosphere.", "Building immersive worlds." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 150,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Subtext, character voice in dialogue, formatting.", "Writing effective and natural dialogue." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 151,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Identifying parts of speech in sentences.", "Understanding nouns, verbs, adjectives, etc." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 152,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Simple, compound, complex, compound-complex sentences.", "Clauses, phrases, and sentence types." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 153,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Common punctuation errors and fixes.", "Correct usage of commas, semicolons, apostrophes, etc." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 154,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Identifying and correcting frequent mistakes.", "Subject-verb agreement, pronoun usage, modifiers." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 155,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Topic sentences, transitions, thesis statements.", "Organizing ideas effectively." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 156,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Scanning poetry, identifying different meters.", "Rhythm, meter, rhyme schemes." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 157,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Identifying and interpreting figurative language.", "Metaphor, simile, personification, hyperbole." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 158,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Analyzing the musicality of poetry.", "Alliteration, assonance, consonance, onomatopoeia." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 159,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Recognizing and analyzing different poetic structures.", "Sonnets, haikus, villanelles, free verse." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 160,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Close reading techniques and thematic analysis.", "Developing analytical arguments about poetry." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 161,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Key periods and influential playwrights.", "From ancient Greek tragedy to modern drama." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 162,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Aristotle's Poetics and dramatic structure.", "Plot, character, theme, dialogue, spectacle." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 163,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Visualizing the play and interpreting character motivations.", "Understanding stage directions and subtext." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 164,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Characteristics and examples of different genres.", "Tragedy, comedy, tragicomedy, melodrama." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 165,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Overview of the process from script to stage.", "Roles in theater (director, actor, designer)." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 166,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Brainstorming techniques, prompts, observation.", "Finding inspiration for fiction stories." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 167,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Impact of POV choices on the story.", "Choosing the right perspective (1st, 3rd limited/omniscient)." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 168,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Techniques for showing emotion and action.", "Using concrete details to engage readers." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 169,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Scene structure, pacing within scenes, transitions.", "Building blocks of a story." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 170,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Self-editing, seeking feedback, common pitfalls.", "Techniques for improving a draft." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 171,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Understanding different forms and their conventions.", "Memoir, biography, essays, journalism." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 172,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Interviews, archival research, evaluating sources.", "Gathering information for non-fiction." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 173,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Chronological, thematic, and narrative structures.", "Organizing factual material effectively." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 174,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Using vivid language, maintaining accuracy.", "Engaging readers with factual content." });

            migrationBuilder.UpdateData(
                table: "lessons",
                keyColumn: "lessonId",
                keyValue: 175,
                columns: new[] { "lessonContent", "lessonDescription" },
                values: new object[] { "Fact-checking, privacy concerns, representation.", "Responsibilities when writing about real people and events." });
        }
    }
}
