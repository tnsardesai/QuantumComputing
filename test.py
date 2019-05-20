import numpy as np
import itertools

from pyquil import Program, get_qc
from pyquil.gates import *
from pyquil.quil import DefGate

uf = [['a',0],[0,1]]
# Get the Quil definition for the new gate
uf_definition = DefGate("UF", uf)
# Get the gate constructor
UF = uf_definition.get_constructor()

p = Program()
p += uf_definition