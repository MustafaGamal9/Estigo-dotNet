using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Estigo.Migrations
{
    /// <inheritdoc />
    public partial class finalExams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BankOfQuestions",
                columns: new[] { "Id", "CorrectAnswer", "ExamId", "OptionA", "OptionB", "OptionC", "OptionD", "QuestionText" },
                values: new object[,]
                {
                    { 471, "A", 18, "1", "-1", "i", "-i", "What is the value of 'i' raised to the power of 4 (i^4), where 'i' is the imaginary unit?" },
                    { 472, "B", 18, "Differentiation", "Integration", "Factorization", "Extrapolation", "The process of finding the area under a curve is known as:" },
                    { 473, "D", 18, "The limit of f(x) as x approaches 'a' exists", "f(a) is defined", "The limit of f(x) as x approaches 'a' equals f(a)", "All of the above", "A function f(x) is continuous at a point 'a' if which condition is met?" },
                    { 474, "C", 18, "Sine", "Tangent", "Secant", "Cosecant", "Which trigonometric function is the reciprocal of cosine?" },
                    { 475, "C", 18, "An identity matrix", "A zero matrix", "An involutory matrix", "A singular matrix", "A matrix that is its own inverse is called:" },
                    { 476, "B", 18, "Real root", "Complex root", "Rational root", "Integer root", "The Fundamental Theorem of Algebra states that every non-constant single-variable polynomial with complex coefficients has at least one:" },
                    { 477, "A", 18, "0", "1", "Greater than 1", "Between 0 and 1", "What is the eccentricity of a circle in conic sections?" },
                    { 478, "B", 18, "nx^(n+1)", "n*x^(n-1)", "x^n / n", "(n-1)x^n", "The power rule for derivatives states that d/dx(x^n) =" },
                    { 479, "B", 18, "Intersection of A and B", "Union of A and B", "Complement of A", "Cartesian product of A and B", "In set theory, the set of all elements that are in A or in B (or in both) is called the:" },
                    { 480, "C", 18, "A function that is only injective (one-to-one)", "A function that is only surjective (onto)", "A function that is both injective and surjective", "A function that is neither injective nor surjective", "What does the term 'bijection' refer to in functions?" },
                    { 481, "C", 18, "Translation", "Rotation", "Reflection", "Dilation", "Which geometric transformation involves flipping a figure over a line?" },
                    { 482, "B", 18, "Permutations P(n,k)", "Combinations C(n,k)", "Factorial of n+k", "Arithmetic series sum", "The expression (n!) / (k!(n-k)!) is the formula for:" },
                    { 483, "B", 18, "Always false", "Always true", "Sometimes true, sometimes false", "Undefined", "A tautology in propositional logic is a statement that is:" },
                    { 484, "A", 18, "cos(x)", "-sin(x)", "-cos(x)", "tan(x)", "What is the derivative of sin(x)?" },
                    { 485, "B", 18, "It has no cycles", "Every vertex is connected to every other vertex", "It is a tree", "It is planar", "A graph is considered 'complete' if:" },
                    { 486, "B", 15, "Summing all values", "Subtracting the minimum value from the maximum value", "Finding the most frequent value", "Averaging all values", "The range of a dataset is calculated by:" },
                    { 487, "C", 15, "The null hypothesis being true", "The alternative hypothesis being true", "Observing the test statistic (or more extreme) if the null hypothesis is true", "Making a Type II error", "A p-value in hypothesis testing represents the probability of:" },
                    { 488, "D", 15, "Symmetric about the mean", "Bell-shaped curve", "Mean, median, and mode are equal", "Skewed to the right", "Which of these is NOT a characteristic of a normal distribution?" },
                    { 489, "B", 15, "P(A) * P(B)", "P(A) + P(B)", "P(A) + P(B) - P(A and B)", "0", "If events A and B are mutually exclusive, then P(A or B) is:" },
                    { 490, "B", 15, "Perfect positive linear relationship", "Perfect negative linear relationship", "No linear relationship", "Weak positive linear relationship", "What does a correlation coefficient of -1 indicate?" },
                    { 501, "A", 35, "Joule/second (J/s)", "Newton-meter (N·m)", "Kilogram-meter/second (kg·m/s)", "Coulomb/second (C/s)", "The unit of power is the Watt (W), which is equivalent to:" },
                    { 502, "C", 35, "Newton's First Law", "Newton's Second Law", "Newton's Third Law", "Law of Conservation of Momentum", "Which law states that for every action, there is an equal and opposite reaction?" },
                    { 503, "B", 35, "Product", "Sum", "Reciprocal of the sum of reciprocals", "Average", "In a series circuit, the total resistance is the ___ of individual resistances." },
                    { 504, "B", 35, "Wave", "Particle (photon)", "Continuous", "Magnetic", "The photoelectric effect demonstrates the ___ nature of light." },
                    { 505, "C", 35, "Volt (V)", "Ampere (A)", "Tesla (T)", "Weber (Wb)", "What is the SI unit of magnetic field strength?" },
                    { 506, "C", 35, "They reflect off each other", "They cancel each other out completely", "Their displacements add algebraically", "Their frequencies double", "The principle of superposition in waves states that when two waves meet:" },
                    { 507, "A", 35, "Heat added minus work done by the system", "Work done by the system minus heat added", "Heat added plus work done on the system", "Always zero", "According to the First Law of Thermodynamics, the change in internal energy of a system is equal to:" },
                    { 508, "C", 35, "Velocity", "Acceleration", "Total momentum", "Force", "Which quantity remains constant in an isolated system according to the law of conservation of momentum?" },
                    { 509, "B", 35, "Real and inverted", "Virtual and upright", "Real and upright", "Virtual and inverted", "A concave lens always produces images that are:" },
                    { 510, "B", 35, "Temperature", "Cross-sectional area", "Voltage", "Current", "The resistance of a wire is directly proportional to its length and inversely proportional to its:" },
                    { 511, "B", 35, "Alpha decay", "Beta-minus decay", "Gamma decay", "Positron emission (Beta-plus decay)", "Which type of nuclear decay involves the emission of an electron?" },
                    { 512, "B", 35, "f = vλ", "f = v/λ", "f = λ/v", "f = v + λ", "The frequency of a wave is related to its wavelength (λ) and speed (v) by the equation:" },
                    { 513, "C", 35, "Tangent to the circle", "Away from the center", "Towards the center of the circle", "In the direction of velocity", "In a uniform circular motion, the acceleration vector is always directed:" },
                    { 514, "B", 35, "Relative to the observer", "Constant for all observers", "Dependent on the source's speed", "Variable", "Special Relativity postulates that the laws of physics are the same in all inertial frames and that the speed of light in a vacuum is:" },
                    { 515, "B", 35, "First Law of Thermodynamics", "Second Law of Thermodynamics", "Zeroth Law of Thermodynamics", "Third Law of Thermodynamics", "The tendency of a system to move towards a state of greater disorder is described by the:" },
                    { 516, "B", 53, "Glucose", "ATP (Adenosine Triphosphate)", "DNA", "RNA", "What is the primary molecule used by cells for energy currency?" },
                    { 517, "B", 53, "Meiosis", "Mitosis", "Fertilization", "Binary Fission", "The process where a cell divides to produce two genetically identical daughter cells is:" },
                    { 518, "B", 53, "Cellulose", "Phospholipids", "Starch", "Amino acids", "Which of these is a key component of the cell membrane, forming a bilayer?" },
                    { 519, "C", 53, "Nucleus", "Mitochondrion", "Ribosome", "Golgi apparatus", "The site of protein synthesis in a eukaryotic cell is the:" },
                    { 520, "C", 53, "Plantae", "Animalia", "Fungi", "Protista", "Which kingdom do mushrooms and yeasts belong to?" },
                    { 521, "B", 53, "Genotype", "Phenotype", "Allele", "Genome", "The observable characteristics of an organism, resulting from its genotype and environment, are its:" },
                    { 522, "A", 53, "To absorb light energy", "To produce glucose", "To release oxygen", "To transport water", "What is the primary role of chlorophyll in photosynthesis?" },
                    { 523, "C", 53, "Community", "Ecosystem", "Population", "Biome", "A group of individuals of the same species living in the same area is called a:" },
                    { 524, "C", 53, "Respiratory System", "Digestive System", "Circulatory System", "Nervous System", "Which human body system is primarily responsible for transporting oxygen, nutrients, and waste?" },
                    { 525, "C", 53, "Transcription", "Translation", "Replication", "Mutation", "The process by which DNA makes a copy of itself is called:" },
                    { 526, "D", 53, "Lipids", "Carbohydrates", "Nucleic Acids", "Proteins", "What are enzymes primarily composed of?" },
                    { 527, "C", 53, "Parasitism", "Commensalism", "Mutualism", "Predation", "The interaction between two different species where both benefit is called:" },
                    { 528, "C", 53, "Presence of a nucleus", "Membrane-bound organelles", "Circular DNA not enclosed in a nucleus", "Multiple linear chromosomes", "Which of the following is a characteristic of prokaryotic cells but not eukaryotic cells?" },
                    { 529, "B", 53, "Reproduce rapidly", "Maintain a stable internal environment", "Evolve over time", "Respond to external stimuli", "Homeostasis refers to the ability of an organism to:" },
                    { 530, "C", 53, "Herbivores", "Carnivores", "Producers (e.g., plants)", "Decomposers", "The first trophic level in an ecosystem is typically occupied by:" },
                    { 531, "B", 70, "Mass number", "Atomic number", "Isotope", "Ion charge", "The number of protons in an atom's nucleus defines its:" },
                    { 532, "C", 70, "Oxygen (O)", "Nitrogen (N)", "Helium (He)", "Hydrogen (H)", "Which of the following is an example of a noble gas?" },
                    { 533, "A", 70, "Strongly acidic", "Weakly acidic", "Neutral", "Weakly basic", "A solution with a pH of 3 is considered:" },
                    { 534, "B", 70, "Reduction", "Oxidation", "Neutralization", "Hydration", "What type of reaction involves the loss of electrons by a chemical species?" },
                    { 535, "C", 70, "Gram", "Liter", "Mole", "Milliliter", "Avogadro's number (approximately 6.022 x 10^23) represents the number of entities in one:" },
                    { 536, "D", 70, "Poor conductor of electricity", "Brittle solid", "Forms anions readily", "Good conductor of heat and electricity", "Which of these is a characteristic property of metals?" },
                    { 537, "B", 70, "Energy is conserved", "Mass is conserved", "Volume is conserved", "Moles are conserved", "The law of conservation of mass states that in a chemical reaction:" },
                    { 538, "B", 70, "Inorganic Chemistry", "Organic Chemistry", "Physical Chemistry", "Analytical Chemistry", "Which branch of chemistry deals primarily with carbon-containing compounds?" },
                    { 539, "B", 70, "Increasing the activation energy", "Decreasing the activation energy", "Increasing the temperature", "Shifting the equilibrium", "A catalyst increases the rate of a chemical reaction by:" },
                    { 540, "B", 70, "CnH2n", "CnH2n+2", "CnH2n-2", "CnHn", "What is the general formula for alkanes?" },
                    { 541, "C", 70, "Melting", "Evaporation", "Sublimation", "Condensation", "The process by which a solid changes directly to a gas without passing through the liquid phase is called:" },
                    { 542, "C", 70, "Sodium (Na)", "Calcium (Ca)", "Chlorine (Cl)", "Sulfur (S)", "Which of the following elements is a halogen?" },
                    { 543, "B", 70, "The actual number of atoms of each element", "The simplest whole-number ratio of atoms", "The structural arrangement of atoms", "The molecular weight of the compound", "The empirical formula of a compound represents:" },
                    { 544, "C", 70, "Ethane", "Propane", "Methane", "Butane", "What is the main component of natural gas?" },
                    { 545, "B", 70, "Absorbed by the system", "Released by the system", "Neither absorbed nor released", "Converted to work", "In an exothermic reaction, heat is:" },
                    { 546, "C", 88, "Second-person", "Third-person limited", "First-person", "Third-person omniscient", "A story told from the 'I' perspective is using which point of view?" },
                    { 547, "B", 88, "Metaphor", "Simile", "Personification", "Hyperbole", "The use of 'like' or 'as' to compare two unlike things is a:" },
                    { 548, "B", 88, "Period (.)", "Comma (,)", "Semicolon (;)", "Question Mark (?)", "Which punctuation mark is used to indicate a pause or to separate items in a series?" },
                    { 549, "C", 88, "Plot", "Setting", "Theme", "Conflict", "The underlying meaning or message the author conveys in a literary work is the:" },
                    { 550, "C", 88, "Protagonist", "Narrator", "Antagonist", "Foil", "A character who opposes the main character is the:" },
                    { 551, "C", 88, "Adverb", "Verb", "Adjective", "Preposition", "What part of speech describes a noun or pronoun (e.g., 'beautiful' flower)?" },
                    { 552, "B", 88, "Diction", "Syntax", "Tone", "Imagery", "The structure of a sentence, including the arrangement of words and phrases, is known as:" },
                    { 553, "C", 88, "Realism", "Historical Fiction", "Epic", "Satire", "Which literary genre typically features a hero on a quest, often involving supernatural elements?" },
                    { 554, "B", 88, "Mood", "Tone", "Theme", "Plot", "A writer's attitude toward the subject or audience, conveyed through word choice and style, is the:" },
                    { 555, "C", 88, "Topic sentence", "Supporting detail", "Thesis statement", "Conclusion", "In essay writing, the sentence that states the main argument or purpose of the essay is the:" },
                    { 556, "C", 88, "Simile", "Metaphor", "Personification", "Allusion", "Giving human qualities to an inanimate object or animal is called:" },
                    { 557, "B", 88, "Allegory", "Anecdote", "Analogy", "Aphorism", "A short, amusing or interesting story about a real incident or person is an:" },
                    { 558, "B", 88, "Biography", "Autobiography", "Memoir", "Journal", "Which of the following is a type of non-fiction that tells the story of a person's life, written by that person?" },
                    { 559, "B", 88, "Tone", "Mood", "Style", "Voice", "The feeling or atmosphere that a writer creates for the reader is the:" },
                    { 560, "C", 88, "Pathos", "Logos", "Satire", "Foreshadowing", "The literary technique of using humor, irony, exaggeration, or ridicule to expose and criticize people's stupidity or vices is:" }
                });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ExamDescription", "ExamTitle" },
                values: new object[] { "Comprehensive test of statistical concepts, data visualization, probability distributions, conditional probability, and expected value.", "Statistics & Probability Comprehensive Exam" });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ExamDescription", "ExamTitle", "final" },
                values: new object[] { "Comprehensive test of core mathematical concepts including algebra, calculus, geometry, trigonometry, and discrete math.", "Core Mathematics Comprehensive Exam", true });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ExamDescription", "ExamTitle", "final" },
                values: new object[] { "Comprehensive test of classical mechanics, electricity, magnetism, optics, thermodynamics, and modern physics concepts.", "Physics Comprehensive Exam", true });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ExamDescription", "ExamTitle", "final" },
                values: new object[] { "Comprehensive test of cell biology, genetics, physiology, ecology, botany, zoology, and microbiology.", "Biology Comprehensive Exam", true });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ExamDescription", "ExamTitle", "final" },
                values: new object[] { "Comprehensive test of organic, inorganic, physical, analytical, bio, environmental, and theoretical chemistry.", "Chemistry Comprehensive Exam", true });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ExamDescription", "ExamTitle", "final" },
                values: new object[] { "Comprehensive test of literary analysis, creative writing, grammar, composition, and non-fiction.", "English & Literature Comprehensive Exam", true });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "BankOfQuestions",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ExamDescription", "ExamTitle" },
                values: new object[] { "Test your ability to calculate measures for random variables.", "Expected Value and Variance Exam" });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ExamDescription", "ExamTitle", "final" },
                values: new object[] { "Test your knowledge of basic graph concepts.", "Introduction to Graph Theory Exam", false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ExamDescription", "ExamTitle", "final" },
                values: new object[] { "Test your conceptual understanding of general relativity.", "Introduction to General Relativity Exam", false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "ExamDescription", "ExamTitle", "final" },
                values: new object[] { "Test your knowledge of microbes in ecosystems, disease, and industry.", "Microbial Roles Exam", false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "ExamDescription", "ExamTitle", "final" },
                values: new object[] { "Test your basic understanding of Hartree-Fock and DFT.", "Computational Chemistry Methods Exam", false });

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "ExamDescription", "ExamTitle", "final" },
                values: new object[] { "Test your understanding of responsibilities in non-fiction writing.", "Ethics in Non-fiction Exam", false });
        }
    }
}
