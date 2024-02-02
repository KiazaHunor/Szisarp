
import matplotlib

print(matplotlib.__version__)

import matplotlib.pyplot as plt
import numpy as np



xpoints = np.array([0, 16])
ypoints = np.array([0, 25])


x=[0,50,50,0,0]
y=[0,0,50,50,0]
plt.plot(x, y)
plt.show()
